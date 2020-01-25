import React, { useState } from "react"
import { Segment, Form, Button } from "semantic-ui-react"
import { IPawn } from "../../models"
interface IProps {
  handleSubmit: (pawn: IPawn) => void
  handleCancel: () => void
  pawn: IPawn
}
//TODO: Until implement store, use props
export default ({ handleCancel, handleSubmit, pawn }: IProps) => {
  return (
    <>
      <Segment clearing>
        <Form onSubmit={e => handleSubmit(pawn)}>
          <Form.Input placeholder='Name' value={pawn.name} />
          <Form.TextArea
            rows={4}
            placeholder='Description'
            value={pawn.description}
          />
          <Form.Input placeholder='Image' value={pawn.image} />
          <Form.Dropdown
            placeholder='Category'
            selection
            options={dropdownInitialState}
          />
          <Button type='submit' floated='right' positive content='Submit' />
          <Button
            type='submit'
            floated='right'
            content='Cancel'
            onClick={handleCancel}
          />
        </Form>
      </Segment>
    </>
  )
}

var dropdownInitialState = [
  {
    key: "Children of Ba'al",
    text: "Children of Ba'al",
    value: "Christian",
    image: {
      avatar: true,
      src:
        "https://cdn.discordapp.com/attachments/643545635005530112/656123992356159499/Baal_a.jpg"
    }
  },
  {
    key: "Rebels",
    text: "Rebels",
    value: "Christian",
    image: {
      avatar: true,
      src:
        "https://cdn.discordapp.com/attachments/643545635005530112/656123992356159499/Baal_a.jpg"
    }
  },
  {
    key: "Government",
    text: "Government",
    value: "Christian",
    image: {
      avatar: true,
      src:
        "https://cdn.discordapp.com/attachments/643545635005530112/656123992356159499/Baal_a.jpg"
    }
  },
  {
    key: "Item",
    text: "Item",
    value: "Christian",
    image: {
      avatar: true,
      src:
        "https://cdn.discordapp.com/attachments/643545635005530112/656123992356159499/Baal_a.jpg"
    }
  },
  {
    key: "Building",
    text: "Building",
    value: "Christian",
    image: {
      avatar: true,
      src:
        "https://cdn.discordapp.com/attachments/643545635005530112/656123992356159499/Baal_a.jpg"
    }
  }
]
