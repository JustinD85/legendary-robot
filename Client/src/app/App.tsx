import React, { useState, useEffect } from "react"
import "./App.css"
import axios, { AxiosResponse } from "axios"
import { Header, Icon, List } from "semantic-ui-react"

const App: React.FC = () => {
  //types will be moved in future
  type gameobject = {
    id: string
    date: Date
    isValid: boolean
    name: string
    image: string
    description: string
  }
  let gameobjects: gameobject[] = []
  const defaultState = { loading: true, gameobjects }
  const [state, setState] = useState(defaultState)

  const getData = async () => {
    const response: AxiosResponse<gameobject[]> = await axios.get(
      "http://localhost:5000/api/gameobjects"
    )

    setState({
      loading: false,
      gameobjects: response.data
    })
  }

  useEffect(() => {
    getData()
  }, [])
  console.log(state)

  return (
    <>
      <Header as='h1'>
        <Icon name='code' />
        <Header.Content>Welcome to Madfunctional LLC</Header.Content>
      </Header>
      <List>
        {state.gameobjects.map((gameobject: gameobject) => (
          <List.Item key={gameobject.id}>
            Name: {gameobject.name}
            <hr />
            <img src={gameobject.image} alt='placeholder' />
            <hr />
            Description: {gameobject.description}
            <hr />
            Created: {new Date(gameobject.date).toDateString()}
            <hr />
            Valid: {String(gameobject.isValid)}
          </List.Item>
        ))}
      </List>
    </>
  )
}
export default App
