import React from "react"
import { Grid, SemanticWIDTHS } from "semantic-ui-react"

interface IProps {
  content: React.FC
  size: SemanticWIDTHS
}

export default ({ content: Content, size }: IProps) => (
  <Grid.Column width={size}>{!!Content && <Content />}</Grid.Column>
)
