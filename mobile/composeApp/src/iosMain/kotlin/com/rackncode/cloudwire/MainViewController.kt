package com.rackncode.cloudwire

import androidx.compose.ui.window.ComposeUIViewController
import com.rackncode.cloudwire.di.initKoin

fun MainViewController() = ComposeUIViewController(
    configure = {
        initKoin()
    }
) {
    App()
}