import React from "react"
import { List, Container } from "semantic-ui-react"
import { IPawn } from "../../models"
import Pawn from "./Pawn"

//In future will not have the generic type pawn
// Will have a type of pawn instead

interface IProps {
  pawns: IPawn[]
}

export default ({ pawns }: IProps) => {
  return (
    <Container>
      <List
        style={{
          maxHeight: "60vh",
          display: "flex",
          flexWrap: "wrap",
          overflow: "scroll"
        }}
      >
        {pawns.map((pawn: IPawn) => (
          <Pawn key={pawn.id} pawn={pawn} />
        ))}
      </List>
    </Container>
  )
}
