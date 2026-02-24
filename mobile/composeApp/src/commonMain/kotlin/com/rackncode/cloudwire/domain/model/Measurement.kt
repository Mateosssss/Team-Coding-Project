package com.rackncode.cloudwire.domain.model

import com.rackncode.cloudwire.domain.helpers.CertificationStatus
import com.rackncode.cloudwire.domain.helpers.MeasurementType

data class Measurement(
    val id: String,
    val outletId: String,
    val serviceWorkerId: String,
    val attachmentId: String,
    val measurementType: MeasurementType,
    val technicalDetails: String,
    val status: CertificationStatus
)
