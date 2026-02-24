package com.rackncode.cloudwire.domain.model

import com.rackncode.cloudwire.domain.helpers.WorkStatus
import kotlinx.datetime.LocalDateTime

data class WorkStage(
    val id: String,
    val stageName: String,
    val description: String,
    val assignedUserId: String,
    val deadline: LocalDateTime,
    val status: WorkStatus,
)
