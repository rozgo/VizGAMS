#include "DynamicSimulation.h"

std::string platform ("debug");
std::string algorithm ("debug");

ADynamicSimulation::ADynamicSimulation()
{
	PrimaryActorTick.bCanEverTick = true;
}

void ADynamicSimulation::BeginPlay()
{
	Super::BeginPlay();

	knowledge = new madara::knowledge::KnowledgeBase();
	loop = new gams::controllers::BaseController(*knowledge);

	loop->init_vars (1, 4);
	loop->init_algorithm (algorithm);
	loop->init_platform (platform);
}

void ADynamicSimulation::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

	loop->run_once ();

	std::string info;
	knowledge->to_string(info);
	FString Info(info.c_str());
	UE_LOG(LogTemp, Warning, TEXT("Knowledge: %s"), *Info);
}

void ADynamicSimulation::BeginDestroy()
{
    Super::BeginDestroy();
	
	delete loop;
	delete knowledge;
}
