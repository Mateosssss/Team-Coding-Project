package com.rackncode.cloudwire.domain.model

import com.rackncode.cloudwire.domain.helpers.UserRole

data class User(
    val id: String,
    val email: String,
    val passwordHash: String,
    val nameSurname: String,
    val userRole: UserRole,
)
