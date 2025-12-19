package com.rackncode.cloudwire.domain.model

data class RackPanel(
    val id: String,
    val networkRackId: String,
    val type: String,
    val portNumber: String,
    val position: String
)
