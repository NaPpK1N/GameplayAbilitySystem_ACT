// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"
#include "GasCharacterBase.generated.h"

UCLASS()
class GASGAME_API AGasCharacterBase : public ACharacter
{
	GENERATED_BODY()

public:
	// Sets default values for this character's properties
	AGasCharacterBase();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;


};
