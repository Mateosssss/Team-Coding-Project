package com.rackncode.cloudwire.domain.model


data class FileAttachment(
    val id: String,
    val fileName: String,
    val fileType: String,
    val url: String,
    val size: Long,
    val uploadedById: String?
)