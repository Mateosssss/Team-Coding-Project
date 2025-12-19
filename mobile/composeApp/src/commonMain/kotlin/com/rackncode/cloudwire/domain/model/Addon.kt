package com.rackncode.cloudwire.domain.model

import com.rackncode.cloudwire.domain.helpers.EntityType

data class Addon(
    val id: String,
    val entityType: EntityType,
    val entityId: String,
    val fileAttachmentId: String,
    val uploadedByUserId: String
)
