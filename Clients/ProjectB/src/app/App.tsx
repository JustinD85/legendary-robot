import React, { useState, useEffect } from "react"
import "./App.css"
import axios from "axios"
import { List, Grid } from "semantic-ui-react"
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
    <Grid celled>
      <Grid.Column width={3}>
        <VerticalMenuContainer />
      </Grid.Column>
      <Grid.Column width={13}>
        <List
          style={{
            height: "100vh",
            display: "flex",
            flexWrap: "wrap",
            overflow: "scroll",
            justifyContent: "center"
          }}
        >
          {pawns.map((pawn: IPawn) => (
            <List.Item key={pawn.id} style={{ width: "300px", margin: "10px" }}>
              Name: {pawn.name}
              <hr />
              ID: {pawn.id}
              <hr />
              Created: {new Date(pawn.createdAt).toDateString()}
              <hr />
              Updated: {new Date(pawn.updatedAt).toDateString()}
              <hr />
              <img
                src={pawn.image}
                style={{ width: "100%" }}
                alt='placeholder'
              />
              <hr />
              Description: {pawn.description}
              <br />
              <br />
              <br />
              <br />
              {/* Replace with Card Component */}
            </List.Item>
          ))}
        </List>
      </Grid.Column>
    </Grid>
  )
}
export default App
