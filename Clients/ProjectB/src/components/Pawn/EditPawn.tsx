import React from "react"
import { Segment, Form } from "semantic-ui-react"

export default () => (
  <>
    <Segment>
      <Form>
        <Form.Input placeholder='Name' />
        <Form.TextArea rows={4} placeholder='Description' />
        <Form.Input placeholder='Image' />
        <Form.Dropdown placeholder='Category' />
      </Form>
    </Segment>
  </>
)
