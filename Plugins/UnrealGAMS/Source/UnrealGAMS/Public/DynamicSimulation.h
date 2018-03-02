#pragma once

#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-constexpr"
#pragma clang diagnostic ignored "-Woverloaded-virtual"

#include "madara/knowledge/KnowledgeBase.h"
#include "gams/controllers/BaseController.h"
#include "madara/logger/GlobalLogger.h"

#pragma clang diagnostic pop

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "DynamicSimulation.generated.h"

UCLASS()
class UNREALGAMS_API ADynamicSimulation : public AActor
{
	GENERATED_BODY()

	madara::knowledge::KnowledgeBase* knowledge;
	gams::controllers::BaseController* loop;
	
public:	

	ADynamicSimulation();

protected:

	virtual void BeginPlay() override;

	virtual void BeginDestroy() override;

public:	

	virtual void Tick(float DeltaTime) override;

};

