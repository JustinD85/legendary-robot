import React, { useState, useEffect } from "react"
import "./App.css"
import axios, { AxiosResponse } from "axios"
import { Header, Icon, List } from "semantic-ui-react"

const App: React.FC = () => {
  //types will be moved in future
  type gameobject = {
    id: string
    createdAt: Date
    updatedAt: Date
    name: string
    image: string
    description: string
  }
  let gameobjects: gameobject[] = []
  const defaultState = { loading: true, gameobjects }
  const [state, setState] = useState(defaultState)

  const getData = async () => {
    const response: AxiosResponse<gameobject[]> = await axios.get(
      "http://localhost:5000/api/pawns"
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
            Created: {new Date(gameobject.createdAt).toDateString()}
            <hr />
            Updated: {new Date(gameobject.updatedAt).toDateString()}
            <hr />
            <img src={gameobject.image} alt='placeholder' />
            <hr />
            Description: {gameobject.description}
            <br />
            <br />
            <br />
            <br />
          </List.Item>
        ))}
      </List>
    </>
  )
}
export default App
