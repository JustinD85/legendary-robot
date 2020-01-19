import React from "react"
import { Grid } from "semantic-ui-react"
import Column from "../layouts/GridColumn"

interface IProps {
  Col1: React.FC
  Col2: React.FC
}

export default ({ Col1, Col2 }: IProps) => (
  <>
    <h1>Welcome to the Content Editor</h1>
    <Grid celled>
      <Column Content={Col1} size={2} />
      <Column Content={Col2} size={14} />
    </Grid>
  </>
)
