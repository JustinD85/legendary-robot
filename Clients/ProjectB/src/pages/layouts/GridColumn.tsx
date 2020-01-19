import React from "react"
import { Grid, SemanticWIDTHS } from "semantic-ui-react"

interface IProps {
  Content: React.FC
  size: SemanticWIDTHS
}

export default ({ Content, size }: IProps) => (
  <Grid.Column width={size}>
    <Content />
  </Grid.Column>
)
