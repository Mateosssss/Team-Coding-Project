package com.rackncode.cloudwire.domain.model


data class Floor(
    val id: String,
    val project: Project,
    val floorNumber: Int,
    val technicalDescription: String,
    val cableType: String,
    val floorPlan: FileAttachment?,
)
