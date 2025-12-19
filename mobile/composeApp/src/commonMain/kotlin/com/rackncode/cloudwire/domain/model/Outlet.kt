package com.rackncode.cloudwire.domain.model

import com.rackncode.cloudwire.domain.helpers.OutletStatus
import com.rackncode.cloudwire.domain.helpers.OutletType
import kotlinx.datetime.LocalDateTime

data class Outlet(
    val id: String,
    val roomId: String,
    val servicedById: String,
    val technicalName: String,
    val type: OutletType,
    val closeUpPhotoId: String,
    val farPhotoId: String,
    val status: OutletStatus,
    val installationDate: LocalDateTime
)
