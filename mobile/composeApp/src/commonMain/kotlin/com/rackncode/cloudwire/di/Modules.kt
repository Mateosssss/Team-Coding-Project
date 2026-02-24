package com.rackncode.cloudwire.di

import com.rackncode.cloudwire.data.core.HttpClientFactory
import org.koin.core.module.Module
import org.koin.dsl.module

expect val platformModule: Module

val appModule = module {
    single { HttpClientFactory.create(get()) }
}



