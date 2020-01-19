import React from "react"
import { List } from "semantic-ui-react"
import { IPawn } from "../../../models"

interface IProps {
  pawn: IPawn
}

export default ({ pawn }: IProps) => (
  <List.Item key={pawn.id} style={{ width: "300px", margin: "10px" }}>
    Name: {pawn.name}
    <hr />
    ID: {pawn.id}
    <hr />
    Created: {new Date(pawn.createdAt).toDateString()}
    <hr />
    Updated: {new Date(pawn.updatedAt).toDateString()}
    <hr />
    <img src={pawn.image} style={{ width: "100%" }} alt='placeholder' />
    <hr />
    Description: {pawn.description}
    <br />
    <br />
    <br />
    <br />
    {/* Replace with Card Component */}
  </List.Item>
)
