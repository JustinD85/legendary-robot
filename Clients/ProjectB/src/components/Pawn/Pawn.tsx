import React from "react"
import { Item, Button, Label, Image, Card } from "semantic-ui-react"
import { IPawn } from "../../models"

interface IProps {
  pawn: IPawn
  handleSelectPawn: (pawn: IPawn) => void
}

export default ({ pawn, handleSelectPawn }: IProps) => (
  <Card key={pawn.id} style={{ width: "300px", margin: "15px" }}>
    <Card.Content>
      <Card.Header>Name: {pawn.name}</Card.Header>

      <Image src={pawn.image} style={{ width: "100%" }} alt='placeholder' />
      <Card.Description>Description: {pawn.description}</Card.Description>
      <Item.Extra>
        <Button
          floated='right'
          content='View'
          color='olive'
          onClick={() => handleSelectPawn(pawn)}
        />
        <Label basic content='Implement Category' />
      </Item.Extra>
    </Card.Content>
  </Card>
)
