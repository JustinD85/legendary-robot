import React from "react"
import { Item, Label, Image, Card, Button } from "semantic-ui-react"
import { IPawn } from "../../models"

interface IProps {
  pawn: IPawn
  handleEdit: (arg0: boolean) => void
  handleCancel: () => void
}

export default ({ pawn, handleEdit, handleCancel }: IProps) => (
  <Card style={{ width: "300px", margin: "15px" }} key={pawn.id}>
    <Card.Content>
      <Card.Header>Name: {pawn.name}</Card.Header>
      <Card.Meta>ID: {pawn.id}</Card.Meta>
      <Card.Meta>Created: {new Date(pawn.createdAt).toDateString()}</Card.Meta>
      <Card.Meta>Updated: {new Date(pawn.updatedAt).toDateString()}</Card.Meta>

      <Image src={pawn.image} style={{ width: "100%" }} alt='placeholder' />
      <Card.Description>Description: {pawn.description}</Card.Description>
      <Item.Extra>
        <Label basic content='Implement Category' />
      </Item.Extra>
      <Button.Group widths={2}>
        <Button
          basic
          color='blue'
          content='Edit'
          onClick={() => handleEdit(true)}
        />
        <Button basic color='grey' content='Cancel' onClick={handleCancel} />
      </Button.Group>
    </Card.Content>
  </Card>
)
