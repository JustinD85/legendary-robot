import React, { useState, useEffect } from "react"
import "./App.css"
import axios from "axios"
import { List } from "semantic-ui-react"
import { IPawn, IItem } from "../models"
import VerticalMenuContainer from "../containers/Menus/VerticalWithHeaderContainer"

const App: React.FC = () => {
  const [pawns, setPawns] = useState<IPawn[]>([])
  const [isLoading, setIsLoading] = useState<boolean>(true)
  const [items, setItems] = useState<IItem[]>([])

  const getData = async () => {
    const response = await axios.get<IPawn[]>("http://localhost:5000/api/pawns")

    setPawns(response.data)
    setIsLoading(false)
  }

  useEffect(() => {
    getData()
  }, [])

  return (
    <div style={{ display: "flex" }}>
      <VerticalMenuContainer />
      <List style={{ height: "100vh", overflow: "scroll" }}>
        {pawns.map((pawn: IPawn) => (
          <List.Item key={pawn.id}>
            Name: {pawn.name}
            <hr />
            Created: {new Date(pawn.createdAt).toDateString()}
            <hr />
            Updated: {new Date(pawn.updatedAt).toDateString()}
            <hr />
            <img src={pawn.image} alt='placeholder' />
            <hr />
            Description: {pawn.description}
            <br />
            <br />
            <br />
            <br />
          </List.Item>
        ))}
      </List>
    </div>
  )
}
export default App
