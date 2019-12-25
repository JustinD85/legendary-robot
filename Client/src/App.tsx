import React, { useState, useEffect } from "react"
import "./App.css"
import axios, { AxiosResponse } from "axios"
import { Header, Icon, List } from "semantic-ui-react"

const App: React.FC = () => {
  //types will be moved in future
  type value = { name: string; id: number }
  let values: value[] = []
  const defaultState = { loading: true, values }
  const [state, setState] = useState(defaultState)

  const getData = async () => {
    const response: AxiosResponse<value[]> = await axios.get(
      "http://localhost:5000/api/values"
    )

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
        {state.values.map((value: value) => (
          <List.Item key={value.id}>{value.name}</List.Item>
        ))}
      </List>
    </>
  )
}
export default App
