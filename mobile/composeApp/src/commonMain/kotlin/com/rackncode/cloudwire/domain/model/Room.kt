package com.rackncode.cloudwire.domain.model

data class Room(
    val id: String,
    val floor: Floor,
    val number: Int,
    val technicalName: String,
    val outletCount: Int,
    val coordinatesOnPlan: String,
    val description: String
)
