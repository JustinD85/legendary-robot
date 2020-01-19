import React from "react"
import { List } from "semantic-ui-react"
import { IPawn } from "../../../models"
import PawnItem from "./PawnItem"

interface IProps {
  pawns: IPawn[]
}

export default ({ pawns }: IProps) => {
  return (
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
        <PawnItem pawn={pawn} />
      ))}
    </List>
  )
}
