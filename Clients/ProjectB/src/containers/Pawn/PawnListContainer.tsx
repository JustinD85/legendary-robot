import React, { useState, useEffect } from "react"
import axios from "axios"
import Pawns from "../../components/Pawn/PawnList"
import { IPawn } from "../../models"

interface IProps {
  handleSelectPawn: (pawn: IPawn) => void
}

//TODO: Until implement store, use props
export default ({ handleSelectPawn }: IProps) => {
  const [pawns, setPawns] = useState<IPawn[]>([])

  const getData = async () => {
    const response = await axios.get<IPawn[]>("http://localhost:5000/api/pawns")

    setPawns(response.data)
  }

  useEffect(() => {
    getData()
  }, [])
  return <Pawns pawns={pawns} handleSelectPawn={handleSelectPawn} />
}
