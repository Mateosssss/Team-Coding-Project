package com.rackncode.cloudwire

import androidx.compose.material3.MaterialTheme
import androidx.compose.runtime.*
import com.rackncode.cloudwire.presentation.login.LoginScreen

@Composable
fun App() {
    MaterialTheme {
        LoginScreen(
            onLoginClick = {email, password ->

            },
            onForgotPasswordClick = {}
        )
    }
}