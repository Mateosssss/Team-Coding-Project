package com.rackncode.cloudwire.domain.model

import kotlinx.datetime.LocalDateTime

data class NetworkRack(
    val id: String,
    val model: String,
    val size: String,
    val location: String,
    val frontViewImageId: String,
    val rearViewImageId: String,
    val sideViewImageId: String,
    val installationDate: LocalDateTime
)
