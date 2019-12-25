import React, { useState, useEffect } from "react"
import "./App.css"
import axios from "axios"
import { Header, Icon, List } from "semantic-ui-react"

const App: React.FC = () => {
  const [state, setState] = useState({ loading: true, values: [] })

  const getData = async () => {
    const response = await axios("http://localhost:5000/api/values")

    setState({
      loading: false,
      values: response.data
    })
  }

  useEffect(() => {
    getData()
  }, [])

  return (
    <>
      <Header as='h1'>
        <Icon name='code' />
        <Header.Content>Welcome to Madfunctional LLC</Header.Content>
      </Header>
      <List>
        {state.values.map((value: any) => (
          <List.Item key={value.id}>{value.name}</List.Item>
        ))}
      </List>
    </>
  )
}
export default App
