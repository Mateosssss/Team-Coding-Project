package com.rackncode.cloudwire.domain.model

import com.rackncode.cloudwire.domain.helpers.ProjectStatus

data class Project(
    val id: String,
    val title: String,
    val description: String,
    val contactPhone: String,
    val contactEmail: String,
    val status: ProjectStatus = ProjectStatus.PLANNED,
    val manager: User,
    val investor: User,
    val localization: Localization?
)
