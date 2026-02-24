package com.rackncode.cloudwire.domain.model

import com.rackncode.cloudwire.domain.helpers.CommentStatus
import com.rackncode.cloudwire.domain.helpers.EntityType
import kotlinx.datetime.LocalDateTime

data class Comment(
    val id: String,
    val entityType: EntityType,
    val entityId: Long,
    val authorId: Long,
    val content: String,
    val status: CommentStatus,
    val createdAt: LocalDateTime
)
