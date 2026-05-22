using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000129 RID: 297
	public class MapGenerator : MonoBehaviour
	{
		// Token: 0x06002435 RID: 9269 RVA: 0x00098738 File Offset: 0x00096938
		// Note: this type is marked as 'beforefieldinit'.
		static MapGenerator()
		{
			Il2CppClassPointerStore<MapGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MapGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr);
			MapGenerator.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "on");
			MapGenerator.NativeFieldInfoPtr_debugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "debugging");
			MapGenerator.NativeFieldInfoPtr_debugMatGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "debugMatGrid");
			MapGenerator.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "map");
			MapGenerator.NativeFieldInfoPtr_checkedMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "checkedMap");
			MapGenerator.NativeFieldInfoPtr_tileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "tileSize");
			MapGenerator.NativeFieldInfoPtr_staticTileArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "staticTileArr");
			MapGenerator.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "width");
			MapGenerator.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "height");
			MapGenerator.NativeFieldInfoPtr_botLef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "botLef");
			MapGenerator.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "startPos");
			MapGenerator.NativeFieldInfoPtr_startPosObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "startPosObj");
			MapGenerator.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "endPos");
			MapGenerator.NativeFieldInfoPtr_tileList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "tileList");
			MapGenerator.NativeFieldInfoPtr_mapLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "mapLines");
			MapGenerator.NativeFieldInfoPtr_quadrant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "quadrant");
			MapGenerator.NativeFieldInfoPtr_levelNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "levelNum");
			MapGenerator.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "level");
			MapGenerator.NativeFieldInfoPtr_density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "density");
			MapGenerator.NativeFieldInfoPtr_pathPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "pathPos");
			MapGenerator.NativeFieldInfoPtr_placedTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "placedTiles");
			MapGenerator.NativeFieldInfoPtr_placedPossums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "placedPossums");
			MapGenerator.NativeFieldInfoPtr_placedRots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "placedRots");
			MapGenerator.NativeFieldInfoPtr_bags1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "bags1");
			MapGenerator.NativeFieldInfoPtr_bags2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "bags2");
			MapGenerator.NativeFieldInfoPtr_bagPals1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "bagPals1");
			MapGenerator.NativeFieldInfoPtr_bagPals2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "bagPals2");
			MapGenerator.NativeFieldInfoPtr_bagWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "bagWeights");
			MapGenerator.NativeFieldInfoPtr_lastPlacedClosedBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "lastPlacedClosedBuilding");
			MapGenerator.NativeFieldInfoPtr_defPalMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "defPalMat");
			MapGenerator.NativeFieldInfoPtr_door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "door");
			MapGenerator.NativeFieldInfoPtr_glass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "glass");
			MapGenerator.NativeFieldInfoPtr_glassDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "glassDoor");
			MapGenerator.NativeFieldInfoPtr_overhangDestroyPts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "overhangDestroyPts");
			MapGenerator.NativeFieldInfoPtr_boundList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "boundList");
			MapGenerator.NativeFieldInfoPtr_pf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "pf");
			MapGenerator.NativeFieldInfoPtr_sg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "sg");
			MapGenerator.NativeFieldInfoPtr_tileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "tileID");
			MapGenerator.NativeFieldInfoPtr_downstairsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "downstairsList");
			MapGenerator.NativeFieldInfoPtr_upstairsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "upstairsList");
			MapGenerator.NativeFieldInfoPtr_stairInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "stairInd");
			MapGenerator.NativeFieldInfoPtr_matGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "matGrid");
			MapGenerator.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "me");
			MapGenerator.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "done");
			MapGenerator.NativeFieldInfoPtr_allowedToStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "allowedToStart");
			MapGenerator.NativeFieldInfoPtr_spawnSafetyOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "spawnSafetyOrigin");
			MapGenerator.NativeFieldInfoPtr_startTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "startTile");
			MapGenerator.NativeFieldInfoPtr_haveMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "haveMap");
			MapGenerator.NativeFieldInfoPtr_labStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "labStrings");
			MapGenerator.NativeFieldInfoPtr_labBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "labBags");
			MapGenerator.NativeFieldInfoPtr_guards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "guards");
			MapGenerator.NativeFieldInfoPtr_guardPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "guardPool");
			MapGenerator.NativeFieldInfoPtr_guardInds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "guardInds");
			MapGenerator.NativeFieldInfoPtr_guardTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "guardTypeCount");
			MapGenerator.NativeFieldInfoPtr_tilePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "tilePool");
			MapGenerator.NativeFieldInfoPtr_previousStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "previousStartPos");
			MapGenerator.NativeFieldInfoPtr_previousStartRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "previousStartRot");
			MapGenerator.NativeFieldInfoPtr_drumLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "drumLoaded");
			MapGenerator.NativeFieldInfoPtr_tileBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "tileBag");
			MapGenerator.NativeFieldInfoPtr_doorInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "doorInd");
			MapGenerator.NativeFieldInfoPtr_glassInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "glassInd");
			MapGenerator.NativeFieldInfoPtr_glassDoorInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "glassDoorInd");
			MapGenerator.NativeFieldInfoPtr_doorArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "doorArr");
			MapGenerator.NativeFieldInfoPtr_glassArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "glassArr");
			MapGenerator.NativeFieldInfoPtr_glassDoorArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "glassDoorArr");
			MapGenerator.NativeFieldInfoPtr_guardsToBeBlownList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "guardsToBeBlownList");
			MapGenerator.NativeFieldInfoPtr_tilePoolObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "tilePoolObj");
			MapGenerator.NativeFieldInfoPtr_tileOffInfoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "tileOffInfoList");
			MapGenerator.NativeFieldInfoPtr_dots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "dots");
			MapGenerator.NativeFieldInfoPtr_dotTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "dotTimer");
			MapGenerator.NativeFieldInfoPtr_dotRotTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "dotRotTimer");
			MapGenerator.NativeFieldInfoPtr_loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "loading");
			MapGenerator.NativeMethodInfoPtr_GetDoor_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666151);
			MapGenerator.NativeMethodInfoPtr_GetGlass_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666152);
			MapGenerator.NativeMethodInfoPtr_GetGlassDoor_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666153);
			MapGenerator.NativeMethodInfoPtr_GetGuard_Public_GameObject_GuardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666154);
			MapGenerator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666155);
			MapGenerator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666156);
			MapGenerator.NativeMethodInfoPtr_GetTile_Public_MapTile_MapTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666157);
			MapGenerator.NativeMethodInfoPtr_MyAwake_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666158);
			MapGenerator.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666159);
			MapGenerator.NativeMethodInfoPtr_IsDrumLoaded_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666160);
			MapGenerator.NativeMethodInfoPtr_LoadedDrum_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666161);
			MapGenerator.NativeMethodInfoPtr_MakeIt_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666162);
			MapGenerator.NativeMethodInfoPtr_AllowedToMakeMap_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666163);
			MapGenerator.NativeMethodInfoPtr_PlaceFatsos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666164);
			MapGenerator.NativeMethodInfoPtr_RemoveOverhangs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666165);
			MapGenerator.NativeMethodInfoPtr_PlaceDoors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666166);
			MapGenerator.NativeMethodInfoPtr_PlaceGlassDoor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666167);
			MapGenerator.NativeMethodInfoPtr_PlaceDoor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666168);
			MapGenerator.NativeMethodInfoPtr_PlaceGlass_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666169);
			MapGenerator.NativeMethodInfoPtr_ToWorld_Private_Vector2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666170);
			MapGenerator.NativeMethodInfoPtr_ToWorld_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666171);
			MapGenerator.NativeMethodInfoPtr_SideToVect_Private_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666172);
			MapGenerator.NativeMethodInfoPtr_PlaceAnimalTiles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666173);
			MapGenerator.NativeMethodInfoPtr_PlaceStartTileNow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666174);
			MapGenerator.NativeMethodInfoPtr_ReallyPlaceTiles_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666175);
			MapGenerator.NativeMethodInfoPtr_Completable_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666176);
			MapGenerator.NativeMethodInfoPtr_Solid_Private_Boolean_MTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666177);
			MapGenerator.NativeMethodInfoPtr_ValidSpiderPos_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666178);
			MapGenerator.NativeMethodInfoPtr_Spiderman_Private_Boolean_Vector2Int_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666179);
			MapGenerator.NativeMethodInfoPtr_Open_Public_Boolean_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666180);
			MapGenerator.NativeMethodInfoPtr_GetTileName_Public_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666181);
			MapGenerator.NativeMethodInfoPtr_FillThatShit_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666182);
			MapGenerator.NativeMethodInfoPtr_GetLeftMostEntrance_Private_Vector2_MapTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666183);
			MapGenerator.NativeMethodInfoPtr_BananaDeal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666184);
			MapGenerator.NativeMethodInfoPtr_FacingToVect_Public_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666185);
			MapGenerator.NativeMethodInfoPtr_RotatedSide_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666186);
			MapGenerator.NativeMethodInfoPtr_PlaceRandomly_Public_Void_MapTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666187);
			MapGenerator.NativeMethodInfoPtr_PlaceRandomlyInQuad_Public_Void_MapTile_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666188);
			MapGenerator.NativeMethodInfoPtr_ItFits_Private_Boolean_MapTile_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666189);
			MapGenerator.NativeMethodInfoPtr_InMap_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666190);
			MapGenerator.NativeMethodInfoPtr_DoorRulesAreAllCoolBrah_Private_Boolean_MTile_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666191);
			MapGenerator.NativeMethodInfoPtr_GetFacingSide_Public_Int32_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666192);
			MapGenerator.NativeMethodInfoPtr_GetFacingWidth_Public_Single_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666193);
			MapGenerator.NativeMethodInfoPtr_GetFacingTile_Public_MTile_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666194);
			MapGenerator.NativeMethodInfoPtr_GetFacingTile_Public_MTile_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666195);
			MapGenerator.NativeMethodInfoPtr_LocalPosToRot_Public_Vector2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666196);
			MapGenerator.NativeMethodInfoPtr_GetUnFat_Private_MapTile_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666197);
			MapGenerator.NativeMethodInfoPtr_GetAnimalTile_Private_MapTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666198);
			MapGenerator.NativeMethodInfoPtr_GetLevel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666199);
			MapGenerator.NativeMethodInfoPtr_GetTileString_Private_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666200);
			MapGenerator.NativeMethodInfoPtr_PlaceTile_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666201);
			MapGenerator.NativeMethodInfoPtr_GetCharPalMat_Public_Material_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666202);
			MapGenerator.NativeMethodInfoPtr_GetCharAmb_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666203);
			MapGenerator.NativeMethodInfoPtr_GetPalMat_Public_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666204);
			MapGenerator.NativeMethodInfoPtr_GetPalInd_Public_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666205);
			MapGenerator.NativeMethodInfoPtr_PlaceTile_Public_Void_MapTile_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666206);
			MapGenerator.NativeMethodInfoPtr_ReallyPlaceTile_Private_MapTile_MapTile_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666207);
			MapGenerator.NativeMethodInfoPtr_UpdatePf_Public_Void_MapTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666208);
			MapGenerator.NativeMethodInfoPtr_ConvertSides_Public_Void_MTile_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666209);
			MapGenerator.NativeMethodInfoPtr_GetQuadNum_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666210);
			MapGenerator.NativeMethodInfoPtr_InitQuads_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666211);
			MapGenerator.NativeMethodInfoPtr_GetNum_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666212);
			MapGenerator.NativeMethodInfoPtr_GetNumeral_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666213);
			MapGenerator.NativeMethodInfoPtr_CharToInt_Public_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666214);
			MapGenerator.NativeMethodInfoPtr_GetCharGuard_Public_GuardType_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666215);
			MapGenerator.NativeMethodInfoPtr_MakeQuads_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666216);
			MapGenerator.NativeMethodInfoPtr_GetLevelSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666217);
			MapGenerator.NativeMethodInfoPtr_GetBag_Public_Il2CppReferenceArray_1_MapTile_Bag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666218);
			MapGenerator.NativeMethodInfoPtr_InBounds_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666219);
			MapGenerator.NativeMethodInfoPtr_GetPalMat_Public_Material_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666220);
			MapGenerator.NativeMethodInfoPtr_GetAmb_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666221);
			MapGenerator.NativeMethodInfoPtr_GetAmb_Public_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666222);
			MapGenerator.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666223);
			MapGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, 100666224);
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x000992D0 File Offset: 0x000974D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71721, XrefRangeEnd = 71735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetDoor_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00099310 File Offset: 0x00097510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71735, XrefRangeEnd = 71749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetGlass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetGlass_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00099350 File Offset: 0x00097550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71763, RefRangeEnd = 71765, XrefRangeStart = 71749, XrefRangeEnd = 71763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetGlassDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetGlassDoor_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00099390 File Offset: 0x00097590
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 71796, RefRangeEnd = 71804, XrefRangeStart = 71765, XrefRangeEnd = 71796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetGuard(MapGenerator.GuardType i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetGuard_Public_GameObject_GuardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x000993DC File Offset: 0x000975DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71804, XrefRangeEnd = 71838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00099410 File Offset: 0x00097610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71838, XrefRangeEnd = 71841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00099444 File Offset: 0x00097644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71850, RefRangeEnd = 71851, XrefRangeStart = 71841, XrefRangeEnd = 71850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapTile GetTile(MapTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetTile_Public_MapTile_MapTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MapTile>(intPtr3) : null;
			}
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00099494 File Offset: 0x00097694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71851, XrefRangeEnd = 71854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MyAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_MyAwake_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x000994D4 File Offset: 0x000976D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71854, XrefRangeEnd = 71860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x00099508 File Offset: 0x00097708
		[CallerCount(0)]
		public unsafe bool IsDrumLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_IsDrumLoaded_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00099544 File Offset: 0x00097744
		[CallerCount(0)]
		public unsafe void LoadedDrum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_LoadedDrum_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x00099578 File Offset: 0x00097778
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 71863, RefRangeEnd = 71866, XrefRangeStart = 71860, XrefRangeEnd = 71863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MakeIt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_MakeIt_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x000995B8 File Offset: 0x000977B8
		[CallerCount(0)]
		public unsafe bool AllowedToMakeMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_AllowedToMakeMap_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x000995F4 File Offset: 0x000977F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71866, XrefRangeEnd = 71873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceFatsos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_PlaceFatsos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x00099628 File Offset: 0x00097828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71873, XrefRangeEnd = 71900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOverhangs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_RemoveOverhangs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x0009965C File Offset: 0x0009785C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71900, XrefRangeEnd = 71933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceDoors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_PlaceDoors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x00099690 File Offset: 0x00097890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71955, RefRangeEnd = 71956, XrefRangeStart = 71933, XrefRangeEnd = 71955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceGlassDoor(int x, int y, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_PlaceGlassDoor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x000996EC File Offset: 0x000978EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71993, RefRangeEnd = 71994, XrefRangeStart = 71956, XrefRangeEnd = 71993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceDoor(int x, int y, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_PlaceDoor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x00099748 File Offset: 0x00097948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72020, RefRangeEnd = 72021, XrefRangeStart = 71994, XrefRangeEnd = 72020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceGlass(int x, int y, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_PlaceGlass_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x000997A4 File Offset: 0x000979A4
		[CallerCount(0)]
		public unsafe Vector2 ToWorld(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_ToWorld_Private_Vector2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x000997FC File Offset: 0x000979FC
		[CallerCount(0)]
		public unsafe float ToWorld(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_ToWorld_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x00099848 File Offset: 0x00097A48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 72025, RefRangeEnd = 72030, XrefRangeStart = 72021, XrefRangeEnd = 72025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 SideToVect(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_SideToVect_Private_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x00099894 File Offset: 0x00097A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72030, XrefRangeEnd = 72033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceAnimalTiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_PlaceAnimalTiles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x000998C8 File Offset: 0x00097AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72044, RefRangeEnd = 72045, XrefRangeStart = 72033, XrefRangeEnd = 72044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceStartTileNow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_PlaceStartTileNow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x000998FC File Offset: 0x00097AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72045, XrefRangeEnd = 72048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ReallyPlaceTiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_ReallyPlaceTiles_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x0009993C File Offset: 0x00097B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72048, XrefRangeEnd = 72057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Completable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_Completable_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00099978 File Offset: 0x00097B78
		[CallerCount(0)]
		public unsafe bool Solid(MTile til)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(til);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_Solid_Private_Boolean_MTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x000999C8 File Offset: 0x00097BC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72059, RefRangeEnd = 72060, XrefRangeStart = 72057, XrefRangeEnd = 72059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidSpiderPos(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_ValidSpiderPos_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x00099A20 File Offset: 0x00097C20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72078, RefRangeEnd = 72080, XrefRangeStart = 72060, XrefRangeEnd = 72078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Spiderman(Vector2Int pos, int comingFrom, int depth, int furthestRight, int consecutiveVerts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comingFrom;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref furthestRight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref consecutiveVerts;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_Spiderman_Private_Boolean_Vector2Int_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x00099AA4 File Offset: 0x00097CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72082, RefRangeEnd = 72083, XrefRangeStart = 72080, XrefRangeEnd = 72082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Open(Vector2 pos, int side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_Open_Public_Boolean_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00099AFC File Offset: 0x00097CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72083, XrefRangeEnd = 72095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTileName(float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetTileName_Public_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x00099B50 File Offset: 0x00097D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72095, XrefRangeEnd = 72105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FillThatShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_FillThatShit_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00099B8C File Offset: 0x00097D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72105, XrefRangeEnd = 72124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetLeftMostEntrance(MapTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetLeftMostEntrance_Private_Vector2_MapTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x00099BDC File Offset: 0x00097DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72124, XrefRangeEnd = 72151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BananaDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_BananaDeal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x00099C10 File Offset: 0x00097E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72152, RefRangeEnd = 72153, XrefRangeStart = 72151, XrefRangeEnd = 72152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 FacingToVect(int side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref side;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_FacingToVect_Public_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x00099C5C File Offset: 0x00097E5C
		[CallerCount(0)]
		public unsafe int RotatedSide(int side, int rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref side;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_RotatedSide_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00099CB4 File Offset: 0x00097EB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72161, RefRangeEnd = 72162, XrefRangeStart = 72153, XrefRangeEnd = 72161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceRandomly(MapTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_PlaceRandomly_Public_Void_MapTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x00099CF8 File Offset: 0x00097EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72169, RefRangeEnd = 72170, XrefRangeStart = 72162, XrefRangeEnd = 72169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceRandomlyInQuad(MapTile tile, int quadNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quadNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_PlaceRandomlyInQuad_Public_Void_MapTile_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00099D48 File Offset: 0x00097F48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72175, RefRangeEnd = 72178, XrefRangeStart = 72170, XrefRangeEnd = 72175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ItFits(MapTile tile, int x, int y, int rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_ItFits_Private_Boolean_MapTile_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00099DC0 File Offset: 0x00097FC0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 72178, RefRangeEnd = 72190, XrefRangeStart = 72178, XrefRangeEnd = 72178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InMap(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_InMap_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00099E18 File Offset: 0x00098018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72207, RefRangeEnd = 72208, XrefRangeStart = 72190, XrefRangeEnd = 72207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoorRulesAreAllCoolBrah(MTile til, Vector2 pos, int rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(til);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_DoorRulesAreAllCoolBrah_Private_Boolean_MTile_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00099E84 File Offset: 0x00098084
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 72213, RefRangeEnd = 72221, XrefRangeStart = 72208, XrefRangeEnd = 72213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFacingSide(Vector2 pos, int facing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref facing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetFacingSide_Public_Int32_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x00099EDC File Offset: 0x000980DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72224, RefRangeEnd = 72226, XrefRangeStart = 72221, XrefRangeEnd = 72224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFacingWidth(Vector2 pos, int facing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref facing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetFacingWidth_Public_Single_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x00099F34 File Offset: 0x00098134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72230, RefRangeEnd = 72231, XrefRangeStart = 72226, XrefRangeEnd = 72230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MTile GetFacingTile(Vector2Int pos, int facing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref facing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetFacingTile_Public_MTile_Vector2Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MTile>(intPtr3) : null;
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x00099F90 File Offset: 0x00098190
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 72235, RefRangeEnd = 72239, XrefRangeStart = 72231, XrefRangeEnd = 72235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MTile GetFacingTile(Vector2 pos, int facing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref facing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetFacingTile_Public_MTile_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MTile>(intPtr3) : null;
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x00099FEC File Offset: 0x000981EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 72240, RefRangeEnd = 72244, XrefRangeStart = 72239, XrefRangeEnd = 72240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 LocalPosToRot(Vector2 pos, int rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_LocalPosToRot_Public_Vector2_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x0009A044 File Offset: 0x00098244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72257, RefRangeEnd = 72258, XrefRangeStart = 72244, XrefRangeEnd = 72257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapTile GetUnFat(bool firstBag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref firstBag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetUnFat_Private_MapTile_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MapTile>(intPtr3) : null;
			}
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0009A090 File Offset: 0x00098290
		[CallerCount(0)]
		public unsafe MapTile GetAnimalTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetAnimalTile_Private_MapTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MapTile>(intPtr3) : null;
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0009A0D0 File Offset: 0x000982D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72258, XrefRangeEnd = 72267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetLevel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x0009A104 File Offset: 0x00098304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72302, RefRangeEnd = 72304, XrefRangeStart = 72267, XrefRangeEnd = 72302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTileString(char a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetTileString_Private_String_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0009A148 File Offset: 0x00098348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72408, RefRangeEnd = 72410, XrefRangeStart = 72304, XrefRangeEnd = 72408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceTile(string st, int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_PlaceTile_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0009A1A8 File Offset: 0x000983A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72434, RefRangeEnd = 72435, XrefRangeStart = 72410, XrefRangeEnd = 72434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetCharPalMat(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetCharPalMat_Public_Material_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x0009A204 File Offset: 0x00098404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72435, XrefRangeEnd = 72436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCharAmb(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetCharAmb_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x0009A25C File Offset: 0x0009845C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 72445, RefRangeEnd = 72459, XrefRangeStart = 72436, XrefRangeEnd = 72445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetPalMat(int burt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref burt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetPalMat_Public_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x0009A2A8 File Offset: 0x000984A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 72501, RefRangeEnd = 72505, XrefRangeStart = 72459, XrefRangeEnd = 72501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPalInd(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetPalInd_Public_Int32_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x0009A2F8 File Offset: 0x000984F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72546, RefRangeEnd = 72548, XrefRangeStart = 72505, XrefRangeEnd = 72546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceTile(MapTile tile, int x, int y, int rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_PlaceTile_Public_Void_MapTile_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x0009A364 File Offset: 0x00098564
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72650, RefRangeEnd = 72652, XrefRangeStart = 72548, XrefRangeEnd = 72650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapTile ReallyPlaceTile(MapTile tile, Vector2 pos, int rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_ReallyPlaceTile_Private_MapTile_MapTile_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MapTile>(intPtr3) : null;
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x0009A3D0 File Offset: 0x000985D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72679, RefRangeEnd = 72680, XrefRangeStart = 72652, XrefRangeEnd = 72679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePf(MapTile bloob)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bloob);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_UpdatePf_Public_Void_MapTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x0009A414 File Offset: 0x00098614
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72689, RefRangeEnd = 72691, XrefRangeStart = 72680, XrefRangeEnd = 72689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConvertSides(MTile til, int rot, bool useOriginal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(til);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useOriginal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_ConvertSides_Public_Void_MTile_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x0009A474 File Offset: 0x00098674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72691, XrefRangeEnd = 72693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetQuadNum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetQuadNum_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x0009A4B0 File Offset: 0x000986B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72705, RefRangeEnd = 72706, XrefRangeStart = 72693, XrefRangeEnd = 72705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitQuads()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_InitQuads_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x0009A4E4 File Offset: 0x000986E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 72710, RefRangeEnd = 72714, XrefRangeStart = 72706, XrefRangeEnd = 72710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNum(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetNum_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x0009A53C File Offset: 0x0009873C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 72714, RefRangeEnd = 72722, XrefRangeStart = 72714, XrefRangeEnd = 72714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNumeral(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetNumeral_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x0009A594 File Offset: 0x00098794
		[CallerCount(0)]
		public unsafe int CharToInt(char toot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref toot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_CharToInt_Public_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x0009A5E0 File Offset: 0x000987E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72722, RefRangeEnd = 72725, XrefRangeStart = 72722, XrefRangeEnd = 72722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapGenerator.GuardType GetCharGuard(char boop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref boop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetCharGuard_Public_GuardType_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x0009A62C File Offset: 0x0009882C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72753, RefRangeEnd = 72754, XrefRangeStart = 72725, XrefRangeEnd = 72753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeQuads()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_MakeQuads_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x0009A660 File Offset: 0x00098860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72776, RefRangeEnd = 72778, XrefRangeStart = 72754, XrefRangeEnd = 72776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLevelSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetLevelSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x0009A694 File Offset: 0x00098894
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 72778, RefRangeEnd = 72782, XrefRangeStart = 72778, XrefRangeEnd = 72778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<MapTile> GetBag(Bag bag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetBag_Public_Il2CppReferenceArray_1_MapTile_Bag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr3) : null;
			}
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x0009A6E4 File Offset: 0x000988E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 72178, RefRangeEnd = 72190, XrefRangeStart = 72178, XrefRangeEnd = 72190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InBounds(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_InBounds_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x0009A73C File Offset: 0x0009893C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 72803, RefRangeEnd = 72809, XrefRangeStart = 72782, XrefRangeEnd = 72803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetPalMat(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetPalMat_Public_Material_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x0009A788 File Offset: 0x00098988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72809, XrefRangeEnd = 72822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAmb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetAmb_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0009A7C4 File Offset: 0x000989C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72822, XrefRangeEnd = 72828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAmb(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_GetAmb_Public_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x0009A810 File Offset: 0x00098A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72828, XrefRangeEnd = 72926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x0009A844 File Offset: 0x00098A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72926, XrefRangeEnd = 72971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00019740 File Offset: 0x00017940
		public MapGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x0009A880 File Offset: 0x00098A80
		// (set) Token: 0x06002482 RID: 9346 RVA: 0x00019749 File Offset: 0x00017949
		public unsafe bool on
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_on);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_on)) = value;
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x0009A8A8 File Offset: 0x00098AA8
		// (set) Token: 0x06002484 RID: 9348 RVA: 0x00019764 File Offset: 0x00017964
		public unsafe bool debugging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_debugging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_debugging)) = value;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x0009A8D0 File Offset: 0x00098AD0
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x0001977F File Offset: 0x0001797F
		public unsafe bool debugMatGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_debugMatGrid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_debugMatGrid)) = value;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x0009A8F8 File Offset: 0x00098AF8
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x0001979A File Offset: 0x0001799A
		public unsafe Il2CppObjectBase map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x0009A928 File Offset: 0x00098B28
		// (set) Token: 0x0600248A RID: 9354 RVA: 0x000197B9 File Offset: 0x000179B9
		public unsafe Il2CppObjectBase checkedMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_checkedMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_checkedMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x0009A958 File Offset: 0x00098B58
		// (set) Token: 0x0600248C RID: 9356 RVA: 0x000197D8 File Offset: 0x000179D8
		public unsafe int tileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tileSize)) = value;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x0009A980 File Offset: 0x00098B80
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x000197F3 File Offset: 0x000179F3
		public unsafe Il2CppReferenceArray<MapTile> staticTileArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_staticTileArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_staticTileArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x0009A9B0 File Offset: 0x00098BB0
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x00019812 File Offset: 0x00017A12
		public unsafe int width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x0009A9D8 File Offset: 0x00098BD8
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x0001982D File Offset: 0x00017A2D
		public unsafe int height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x0009AA00 File Offset: 0x00098C00
		// (set) Token: 0x06002494 RID: 9364 RVA: 0x00019848 File Offset: 0x00017A48
		public unsafe Vector2 botLef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_botLef);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_botLef)) = value;
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x0009AA28 File Offset: 0x00098C28
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x00019863 File Offset: 0x00017A63
		public unsafe Vector2 startPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_startPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_startPos)) = value;
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x0009AA50 File Offset: 0x00098C50
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0001987E File Offset: 0x00017A7E
		public unsafe GameObject startPosObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_startPosObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_startPosObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x0009AA80 File Offset: 0x00098C80
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x0001989D File Offset: 0x00017A9D
		public unsafe Vector2 endPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_endPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_endPos)) = value;
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x0009AAA8 File Offset: 0x00098CA8
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x000198B8 File Offset: 0x00017AB8
		public unsafe List<GameObject> tileList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tileList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tileList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x0009AAD8 File Offset: 0x00098CD8
		// (set) Token: 0x0600249E RID: 9374 RVA: 0x000198D7 File Offset: 0x00017AD7
		public unsafe Il2CppStringArray mapLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_mapLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_mapLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x0009AB08 File Offset: 0x00098D08
		// (set) Token: 0x060024A0 RID: 9376 RVA: 0x000198F6 File Offset: 0x00017AF6
		public unsafe Il2CppReferenceArray<Quadrant> quadrant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_quadrant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quadrant>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_quadrant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x0009AB38 File Offset: 0x00098D38
		// (set) Token: 0x060024A2 RID: 9378 RVA: 0x00019915 File Offset: 0x00017B15
		public unsafe int levelNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_levelNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_levelNum)) = value;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x0009AB60 File Offset: 0x00098D60
		// (set) Token: 0x060024A4 RID: 9380 RVA: 0x00019930 File Offset: 0x00017B30
		public unsafe Level level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_level);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Level>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_level), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x0009AB90 File Offset: 0x00098D90
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x0001994F File Offset: 0x00017B4F
		public unsafe float density
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_density);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_density)) = value;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x0009ABB8 File Offset: 0x00098DB8
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x0001996A File Offset: 0x00017B6A
		public unsafe Vector2 pathPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_pathPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_pathPos)) = value;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x0009ABE0 File Offset: 0x00098DE0
		// (set) Token: 0x060024AA RID: 9386 RVA: 0x00019985 File Offset: 0x00017B85
		public unsafe List<MapTile> placedTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_placedTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_placedTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x0009AC10 File Offset: 0x00098E10
		// (set) Token: 0x060024AC RID: 9388 RVA: 0x000199A4 File Offset: 0x00017BA4
		public unsafe List<Vector2> placedPossums
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_placedPossums);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_placedPossums), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x0009AC40 File Offset: 0x00098E40
		// (set) Token: 0x060024AE RID: 9390 RVA: 0x000199C3 File Offset: 0x00017BC3
		public unsafe List<int> placedRots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_placedRots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_placedRots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x0009AC70 File Offset: 0x00098E70
		// (set) Token: 0x060024B0 RID: 9392 RVA: 0x000199E2 File Offset: 0x00017BE2
		public unsafe List<Il2CppReferenceArray<MapTile>> bags1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_bags1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppReferenceArray<MapTile>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_bags1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x0009ACA0 File Offset: 0x00098EA0
		// (set) Token: 0x060024B2 RID: 9394 RVA: 0x00019A01 File Offset: 0x00017C01
		public unsafe List<Il2CppReferenceArray<MapTile>> bags2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_bags2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppReferenceArray<MapTile>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_bags2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x0009ACD0 File Offset: 0x00098ED0
		// (set) Token: 0x060024B4 RID: 9396 RVA: 0x00019A20 File Offset: 0x00017C20
		public unsafe List<int> bagPals1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_bagPals1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_bagPals1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x0009AD00 File Offset: 0x00098F00
		// (set) Token: 0x060024B6 RID: 9398 RVA: 0x00019A3F File Offset: 0x00017C3F
		public unsafe List<int> bagPals2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_bagPals2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_bagPals2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x060024B7 RID: 9399 RVA: 0x0009AD30 File Offset: 0x00098F30
		// (set) Token: 0x060024B8 RID: 9400 RVA: 0x00019A5E File Offset: 0x00017C5E
		public unsafe List<float> bagWeights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_bagWeights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_bagWeights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x060024B9 RID: 9401 RVA: 0x0009AD60 File Offset: 0x00098F60
		// (set) Token: 0x060024BA RID: 9402 RVA: 0x00019A7D File Offset: 0x00017C7D
		public unsafe bool lastPlacedClosedBuilding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_lastPlacedClosedBuilding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_lastPlacedClosedBuilding)) = value;
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x0009AD88 File Offset: 0x00098F88
		// (set) Token: 0x060024BC RID: 9404 RVA: 0x00019A98 File Offset: 0x00017C98
		public unsafe Material defPalMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_defPalMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_defPalMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x0009ADB8 File Offset: 0x00098FB8
		// (set) Token: 0x060024BE RID: 9406 RVA: 0x00019AB7 File Offset: 0x00017CB7
		public unsafe GameObject door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x0009ADE8 File Offset: 0x00098FE8
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x00019AD6 File Offset: 0x00017CD6
		public unsafe GameObject glass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_glass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_glass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x0009AE18 File Offset: 0x00099018
		// (set) Token: 0x060024C2 RID: 9410 RVA: 0x00019AF5 File Offset: 0x00017CF5
		public unsafe GameObject glassDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_glassDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_glassDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x0009AE48 File Offset: 0x00099048
		// (set) Token: 0x060024C4 RID: 9412 RVA: 0x00019B14 File Offset: 0x00017D14
		public unsafe List<Vector2> overhangDestroyPts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_overhangDestroyPts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_overhangDestroyPts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x060024C5 RID: 9413 RVA: 0x0009AE78 File Offset: 0x00099078
		// (set) Token: 0x060024C6 RID: 9414 RVA: 0x00019B33 File Offset: 0x00017D33
		public unsafe List<Bounds> boundList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_boundList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Bounds>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_boundList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x060024C7 RID: 9415 RVA: 0x0009AEA8 File Offset: 0x000990A8
		// (set) Token: 0x060024C8 RID: 9416 RVA: 0x00019B52 File Offset: 0x00017D52
		public unsafe PathFinding pf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_pf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathFinding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_pf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x060024C9 RID: 9417 RVA: 0x0009AED8 File Offset: 0x000990D8
		// (set) Token: 0x060024CA RID: 9418 RVA: 0x00019B71 File Offset: 0x00017D71
		public unsafe SearchGrid sg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_sg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_sg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060024CB RID: 9419 RVA: 0x0009AF08 File Offset: 0x00099108
		// (set) Token: 0x060024CC RID: 9420 RVA: 0x00019B90 File Offset: 0x00017D90
		public unsafe int tileID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tileID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tileID)) = value;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060024CD RID: 9421 RVA: 0x0009AF30 File Offset: 0x00099130
		// (set) Token: 0x060024CE RID: 9422 RVA: 0x00019BAB File Offset: 0x00017DAB
		public unsafe List<Vector2> downstairsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_downstairsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_downstairsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060024CF RID: 9423 RVA: 0x0009AF60 File Offset: 0x00099160
		// (set) Token: 0x060024D0 RID: 9424 RVA: 0x00019BCA File Offset: 0x00017DCA
		public unsafe List<Vector2> upstairsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_upstairsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_upstairsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060024D1 RID: 9425 RVA: 0x0009AF90 File Offset: 0x00099190
		// (set) Token: 0x060024D2 RID: 9426 RVA: 0x00019BE9 File Offset: 0x00017DE9
		public unsafe int stairInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_stairInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_stairInd)) = value;
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060024D3 RID: 9427 RVA: 0x0009AFB8 File Offset: 0x000991B8
		// (set) Token: 0x060024D4 RID: 9428 RVA: 0x00019C04 File Offset: 0x00017E04
		public unsafe Il2CppObjectBase matGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_matGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_matGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060024D5 RID: 9429 RVA: 0x0009AFE8 File Offset: 0x000991E8
		// (set) Token: 0x060024D6 RID: 9430 RVA: 0x00019C23 File Offset: 0x00017E23
		public unsafe static MapGenerator me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MapGenerator.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MapGenerator.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060024D7 RID: 9431 RVA: 0x0009B010 File Offset: 0x00099210
		// (set) Token: 0x060024D8 RID: 9432 RVA: 0x00019C35 File Offset: 0x00017E35
		public unsafe bool done
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_done);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_done)) = value;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060024D9 RID: 9433 RVA: 0x0009B038 File Offset: 0x00099238
		// (set) Token: 0x060024DA RID: 9434 RVA: 0x00019C50 File Offset: 0x00017E50
		public unsafe bool allowedToStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_allowedToStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_allowedToStart)) = value;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x0009B060 File Offset: 0x00099260
		// (set) Token: 0x060024DC RID: 9436 RVA: 0x00019C6B File Offset: 0x00017E6B
		public unsafe Vector3 spawnSafetyOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_spawnSafetyOrigin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_spawnSafetyOrigin)) = value;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060024DD RID: 9437 RVA: 0x0009B088 File Offset: 0x00099288
		// (set) Token: 0x060024DE RID: 9438 RVA: 0x00019C86 File Offset: 0x00017E86
		public unsafe GameObject startTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_startTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_startTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x0009B0B8 File Offset: 0x000992B8
		// (set) Token: 0x060024E0 RID: 9440 RVA: 0x00019CA5 File Offset: 0x00017EA5
		public unsafe bool haveMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_haveMap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_haveMap)) = value;
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x0009B0E0 File Offset: 0x000992E0
		// (set) Token: 0x060024E2 RID: 9442 RVA: 0x00019CC0 File Offset: 0x00017EC0
		public unsafe Il2CppStringArray labStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_labStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_labStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060024E3 RID: 9443 RVA: 0x0009B110 File Offset: 0x00099310
		// (set) Token: 0x060024E4 RID: 9444 RVA: 0x00019CDF File Offset: 0x00017EDF
		public unsafe Il2CppReferenceArray<Il2CppReferenceArray<MapTile>> labBags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_labBags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<MapTile>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_labBags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x0009B140 File Offset: 0x00099340
		// (set) Token: 0x060024E6 RID: 9446 RVA: 0x00019CFE File Offset: 0x00017EFE
		public unsafe Il2CppReferenceArray<GameObject> guards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_guards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_guards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x0009B170 File Offset: 0x00099370
		// (set) Token: 0x060024E8 RID: 9448 RVA: 0x00019D1D File Offset: 0x00017F1D
		public unsafe Il2CppReferenceArray<List<GameObject>> guardPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_guardPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_guardPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x0009B1A0 File Offset: 0x000993A0
		// (set) Token: 0x060024EA RID: 9450 RVA: 0x00019D3C File Offset: 0x00017F3C
		public unsafe Il2CppStructArray<int> guardInds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_guardInds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_guardInds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x0009B1D0 File Offset: 0x000993D0
		// (set) Token: 0x060024EC RID: 9452 RVA: 0x00019D5B File Offset: 0x00017F5B
		public unsafe int guardTypeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_guardTypeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_guardTypeCount)) = value;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x0009B1F8 File Offset: 0x000993F8
		// (set) Token: 0x060024EE RID: 9454 RVA: 0x00019D76 File Offset: 0x00017F76
		public unsafe List<MapTile> tilePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tilePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MapTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tilePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x0009B228 File Offset: 0x00099428
		// (set) Token: 0x060024F0 RID: 9456 RVA: 0x00019D95 File Offset: 0x00017F95
		public unsafe Vector2 previousStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_previousStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_previousStartPos)) = value;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x060024F1 RID: 9457 RVA: 0x0009B250 File Offset: 0x00099450
		// (set) Token: 0x060024F2 RID: 9458 RVA: 0x00019DB0 File Offset: 0x00017FB0
		public unsafe Quaternion previousStartRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_previousStartRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_previousStartRot)) = value;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x0009B278 File Offset: 0x00099478
		// (set) Token: 0x060024F4 RID: 9460 RVA: 0x00019DCB File Offset: 0x00017FCB
		public unsafe bool drumLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_drumLoaded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_drumLoaded)) = value;
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x0009B2A0 File Offset: 0x000994A0
		// (set) Token: 0x060024F6 RID: 9462 RVA: 0x00019DE6 File Offset: 0x00017FE6
		public unsafe TileBags tileBag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tileBag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileBags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tileBag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x0009B2D0 File Offset: 0x000994D0
		// (set) Token: 0x060024F8 RID: 9464 RVA: 0x00019E05 File Offset: 0x00018005
		public unsafe int doorInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_doorInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_doorInd)) = value;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x0009B2F8 File Offset: 0x000994F8
		// (set) Token: 0x060024FA RID: 9466 RVA: 0x00019E20 File Offset: 0x00018020
		public unsafe int glassInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_glassInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_glassInd)) = value;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x0009B320 File Offset: 0x00099520
		// (set) Token: 0x060024FC RID: 9468 RVA: 0x00019E3B File Offset: 0x0001803B
		public unsafe int glassDoorInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_glassDoorInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_glassDoorInd)) = value;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x0009B348 File Offset: 0x00099548
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x00019E56 File Offset: 0x00018056
		public unsafe List<Transform> doorArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_doorArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_doorArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x0009B378 File Offset: 0x00099578
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x00019E75 File Offset: 0x00018075
		public unsafe List<Transform> glassArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_glassArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_glassArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x0009B3A8 File Offset: 0x000995A8
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x00019E94 File Offset: 0x00018094
		public unsafe List<Transform> glassDoorArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_glassDoorArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_glassDoorArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x0009B3D8 File Offset: 0x000995D8
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x00019EB3 File Offset: 0x000180B3
		public unsafe List<Transform> guardsToBeBlownList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_guardsToBeBlownList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_guardsToBeBlownList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x0009B408 File Offset: 0x00099608
		// (set) Token: 0x06002506 RID: 9478 RVA: 0x00019ED2 File Offset: 0x000180D2
		public unsafe List<GameObject> tilePoolObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tilePoolObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tilePoolObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x0009B438 File Offset: 0x00099638
		// (set) Token: 0x06002508 RID: 9480 RVA: 0x00019EF1 File Offset: 0x000180F1
		public NativeList<MapGenerator.TileOffInfo> tileOffInfoList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tileOffInfoList);
				return new NativeList<MapGenerator.TileOffInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<MapGenerator.TileOffInfo>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_tileOffInfoList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MapGenerator.TileOffInfo>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x0009B468 File Offset: 0x00099668
		// (set) Token: 0x0600250A RID: 9482 RVA: 0x00019F1F File Offset: 0x0001811F
		public unsafe Il2CppReferenceArray<GameObject> dots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_dots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_dots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x0009B498 File Offset: 0x00099698
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x00019F3E File Offset: 0x0001813E
		public unsafe float dotTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_dotTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_dotTimer)) = value;
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x0009B4C0 File Offset: 0x000996C0
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x00019F59 File Offset: 0x00018159
		public unsafe float dotRotTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_dotRotTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_dotRotTimer)) = value;
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x0009B4E8 File Offset: 0x000996E8
		// (set) Token: 0x06002510 RID: 9488 RVA: 0x00019F74 File Offset: 0x00018174
		public unsafe bool loading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_loading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator.NativeFieldInfoPtr_loading)) = value;
			}
		}

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeFieldInfoPtr_debugging;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeFieldInfoPtr_debugMatGrid;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeFieldInfoPtr_map;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeFieldInfoPtr_checkedMap;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeFieldInfoPtr_tileSize;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeFieldInfoPtr_staticTileArr;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeFieldInfoPtr_botLef;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeFieldInfoPtr_startPos;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeFieldInfoPtr_startPosObj;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeFieldInfoPtr_endPos;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeFieldInfoPtr_tileList;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeFieldInfoPtr_mapLines;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeFieldInfoPtr_quadrant;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeFieldInfoPtr_levelNum;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeFieldInfoPtr_density;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeFieldInfoPtr_pathPos;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeFieldInfoPtr_placedTiles;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeFieldInfoPtr_placedPossums;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeFieldInfoPtr_placedRots;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeFieldInfoPtr_bags1;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeFieldInfoPtr_bags2;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeFieldInfoPtr_bagPals1;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeFieldInfoPtr_bagPals2;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeFieldInfoPtr_bagWeights;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeFieldInfoPtr_lastPlacedClosedBuilding;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeFieldInfoPtr_defPalMat;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeFieldInfoPtr_door;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeFieldInfoPtr_glass;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeFieldInfoPtr_glassDoor;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeFieldInfoPtr_overhangDestroyPts;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeFieldInfoPtr_boundList;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeFieldInfoPtr_pf;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeFieldInfoPtr_sg;

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeFieldInfoPtr_tileID;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeFieldInfoPtr_downstairsList;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeFieldInfoPtr_upstairsList;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeFieldInfoPtr_stairInd;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeFieldInfoPtr_matGrid;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeFieldInfoPtr_done;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeFieldInfoPtr_allowedToStart;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeFieldInfoPtr_spawnSafetyOrigin;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeFieldInfoPtr_startTile;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeFieldInfoPtr_haveMap;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeFieldInfoPtr_labStrings;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeFieldInfoPtr_labBags;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeFieldInfoPtr_guards;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeFieldInfoPtr_guardPool;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeFieldInfoPtr_guardInds;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeFieldInfoPtr_guardTypeCount;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeFieldInfoPtr_tilePool;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeFieldInfoPtr_previousStartPos;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeFieldInfoPtr_previousStartRot;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeFieldInfoPtr_drumLoaded;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeFieldInfoPtr_tileBag;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeFieldInfoPtr_doorInd;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeFieldInfoPtr_glassInd;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeFieldInfoPtr_glassDoorInd;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeFieldInfoPtr_doorArr;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeFieldInfoPtr_glassArr;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeFieldInfoPtr_glassDoorArr;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeFieldInfoPtr_guardsToBeBlownList;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeFieldInfoPtr_tilePoolObj;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeFieldInfoPtr_tileOffInfoList;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeFieldInfoPtr_dots;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeFieldInfoPtr_dotTimer;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeFieldInfoPtr_dotRotTimer;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeFieldInfoPtr_loading;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeMethodInfoPtr_GetDoor_Public_Transform_0;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeMethodInfoPtr_GetGlass_Public_Transform_0;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr_GetGlassDoor_Public_Transform_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_GetGuard_Public_GameObject_GuardType_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Public_MapTile_MapTile_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_MyAwake_Public_IEnumerator_0;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeMethodInfoPtr_IsDrumLoaded_Private_Boolean_0;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeMethodInfoPtr_LoadedDrum_Private_Void_0;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeMethodInfoPtr_MakeIt_Public_IEnumerator_0;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeMethodInfoPtr_AllowedToMakeMap_Private_Boolean_0;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeMethodInfoPtr_PlaceFatsos_Public_Void_0;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOverhangs_Public_Void_0;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeMethodInfoPtr_PlaceDoors_Public_Void_0;

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeMethodInfoPtr_PlaceGlassDoor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x040015AB RID: 5547
		private static readonly IntPtr NativeMethodInfoPtr_PlaceDoor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x040015AC RID: 5548
		private static readonly IntPtr NativeMethodInfoPtr_PlaceGlass_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x040015AD RID: 5549
		private static readonly IntPtr NativeMethodInfoPtr_ToWorld_Private_Vector2_Int32_Int32_0;

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeMethodInfoPtr_ToWorld_Private_Single_Int32_0;

		// Token: 0x040015AF RID: 5551
		private static readonly IntPtr NativeMethodInfoPtr_SideToVect_Private_Vector2_Int32_0;

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeMethodInfoPtr_PlaceAnimalTiles_Public_Void_0;

		// Token: 0x040015B1 RID: 5553
		private static readonly IntPtr NativeMethodInfoPtr_PlaceStartTileNow_Public_Void_0;

		// Token: 0x040015B2 RID: 5554
		private static readonly IntPtr NativeMethodInfoPtr_ReallyPlaceTiles_Public_IEnumerator_0;

		// Token: 0x040015B3 RID: 5555
		private static readonly IntPtr NativeMethodInfoPtr_Completable_Private_Boolean_0;

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeMethodInfoPtr_Solid_Private_Boolean_MTile_0;

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeMethodInfoPtr_ValidSpiderPos_Private_Boolean_Int32_Int32_0;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeMethodInfoPtr_Spiderman_Private_Boolean_Vector2Int_Int32_Int32_Int32_Int32_0;

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Boolean_Vector2_Int32_0;

		// Token: 0x040015B8 RID: 5560
		private static readonly IntPtr NativeMethodInfoPtr_GetTileName_Public_String_Single_Single_0;

		// Token: 0x040015B9 RID: 5561
		private static readonly IntPtr NativeMethodInfoPtr_FillThatShit_Public_Boolean_0;

		// Token: 0x040015BA RID: 5562
		private static readonly IntPtr NativeMethodInfoPtr_GetLeftMostEntrance_Private_Vector2_MapTile_0;

		// Token: 0x040015BB RID: 5563
		private static readonly IntPtr NativeMethodInfoPtr_BananaDeal_Private_Void_0;

		// Token: 0x040015BC RID: 5564
		private static readonly IntPtr NativeMethodInfoPtr_FacingToVect_Public_Vector2_Int32_0;

		// Token: 0x040015BD RID: 5565
		private static readonly IntPtr NativeMethodInfoPtr_RotatedSide_Public_Int32_Int32_Int32_0;

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeMethodInfoPtr_PlaceRandomly_Public_Void_MapTile_0;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeMethodInfoPtr_PlaceRandomlyInQuad_Public_Void_MapTile_Int32_0;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeMethodInfoPtr_ItFits_Private_Boolean_MapTile_Int32_Int32_Int32_0;

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeMethodInfoPtr_InMap_Private_Boolean_Int32_Int32_0;

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeMethodInfoPtr_DoorRulesAreAllCoolBrah_Private_Boolean_MTile_Vector2_Int32_0;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeMethodInfoPtr_GetFacingSide_Public_Int32_Vector2_Int32_0;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeMethodInfoPtr_GetFacingWidth_Public_Single_Vector2_Int32_0;

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeMethodInfoPtr_GetFacingTile_Public_MTile_Vector2Int_Int32_0;

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeMethodInfoPtr_GetFacingTile_Public_MTile_Vector2_Int32_0;

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeMethodInfoPtr_LocalPosToRot_Public_Vector2_Vector2_Int32_0;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeMethodInfoPtr_GetUnFat_Private_MapTile_Boolean_0;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimalTile_Private_MapTile_0;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeMethodInfoPtr_GetLevel_Public_Void_0;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeMethodInfoPtr_GetTileString_Private_String_Char_0;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeMethodInfoPtr_PlaceTile_Public_Void_String_Int32_Int32_0;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeMethodInfoPtr_GetCharPalMat_Public_Material_Int32_Int32_0;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeMethodInfoPtr_GetCharAmb_Public_Int32_Int32_Int32_0;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeMethodInfoPtr_GetPalMat_Public_Material_Int32_0;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeMethodInfoPtr_GetPalInd_Public_Int32_Material_0;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeMethodInfoPtr_PlaceTile_Public_Void_MapTile_Int32_Int32_Int32_0;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeMethodInfoPtr_ReallyPlaceTile_Private_MapTile_MapTile_Vector2_Int32_0;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePf_Public_Void_MapTile_0;

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeMethodInfoPtr_ConvertSides_Public_Void_MTile_Int32_Boolean_0;

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeMethodInfoPtr_GetQuadNum_Private_Int32_0;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeMethodInfoPtr_InitQuads_Public_Void_0;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeMethodInfoPtr_GetNum_Public_Int32_Int32_Int32_0;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeMethodInfoPtr_GetNumeral_Public_Int32_Int32_Int32_0;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeMethodInfoPtr_CharToInt_Public_Int32_Char_0;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeMethodInfoPtr_GetCharGuard_Public_GuardType_Char_0;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeMethodInfoPtr_MakeQuads_Public_Void_0;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr_GetLevelSettings_Public_Void_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr_GetBag_Public_Il2CppReferenceArray_1_MapTile_Bag_0;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeMethodInfoPtr_InBounds_Public_Boolean_Int32_Int32_0;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeMethodInfoPtr_GetPalMat_Public_Material_Vector2_0;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeMethodInfoPtr_GetAmb_Public_Int32_0;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeMethodInfoPtr_GetAmb_Public_Int32_Vector3_0;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200032A RID: 810
		[OriginalName("Assembly-CSharp.dll", "", "GuardType")]
		public enum GuardType
		{
			// Token: 0x040035AA RID: 13738
			guard,
			// Token: 0x040035AB RID: 13739
			fat,
			// Token: 0x040035AC RID: 13740
			dyno,
			// Token: 0x040035AD RID: 13741
			lil,
			// Token: 0x040035AE RID: 13742
			armor,
			// Token: 0x040035AF RID: 13743
			rocket,
			// Token: 0x040035B0 RID: 13744
			sniper,
			// Token: 0x040035B1 RID: 13745
			machinegun,
			// Token: 0x040035B2 RID: 13746
			flame,
			// Token: 0x040035B3 RID: 13747
			tranq,
			// Token: 0x040035B4 RID: 13748
			civ,
			// Token: 0x040035B5 RID: 13749
			squad,
			// Token: 0x040035B6 RID: 13750
			invalid
		}

		// Token: 0x0200032B RID: 811
		[StructLayout(2)]
		public struct TileOffInfo
		{
			// Token: 0x0600512F RID: 20783 RVA: 0x0012802C File Offset: 0x0012622C
			// Note: this type is marked as 'beforefieldinit'.
			static TileOffInfo()
			{
				Il2CppClassPointerStore<MapGenerator.TileOffInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "TileOffInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapGenerator.TileOffInfo>.NativeClassPtr);
				MapGenerator.TileOffInfo.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator.TileOffInfo>.NativeClassPtr, "pos");
				MapGenerator.TileOffInfo.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator.TileOffInfo>.NativeClassPtr, "on");
				MapGenerator.TileOffInfo.NativeFieldInfoPtr_rad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator.TileOffInfo>.NativeClassPtr, "rad");
				MapGenerator.TileOffInfo.NativeFieldInfoPtr_onlyX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator.TileOffInfo>.NativeClassPtr, "onlyX");
			}

			// Token: 0x06005130 RID: 20784 RVA: 0x0002F4D3 File Offset: 0x0002D6D3
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapGenerator.TileOffInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x040035B7 RID: 13751
			private static readonly IntPtr NativeFieldInfoPtr_pos;

			// Token: 0x040035B8 RID: 13752
			private static readonly IntPtr NativeFieldInfoPtr_on;

			// Token: 0x040035B9 RID: 13753
			private static readonly IntPtr NativeFieldInfoPtr_rad;

			// Token: 0x040035BA RID: 13754
			private static readonly IntPtr NativeFieldInfoPtr_onlyX;

			// Token: 0x040035BB RID: 13755
			[FieldOffset(0)]
			public Vector2 pos;

			// Token: 0x040035BC RID: 13756
			[FieldOffset(8)]
			public byte on;

			// Token: 0x040035BD RID: 13757
			[FieldOffset(12)]
			public float rad;

			// Token: 0x040035BE RID: 13758
			[FieldOffset(16)]
			public byte onlyX;
		}

		// Token: 0x0200032C RID: 812
		[ObfuscatedName("MapGenerator+<MyAwake>d__81")]
		public sealed class _MyAwake_d__81 : global::Il2CppSystem.Object
		{
			// Token: 0x06005131 RID: 20785 RVA: 0x001280A8 File Offset: 0x001262A8
			// Note: this type is marked as 'beforefieldinit'.
			static _MyAwake_d__81()
			{
				Il2CppClassPointerStore<MapGenerator._MyAwake_d__81>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "<MyAwake>d__81");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapGenerator._MyAwake_d__81>.NativeClassPtr);
				MapGenerator._MyAwake_d__81.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MyAwake_d__81>.NativeClassPtr, "<>1__state");
				MapGenerator._MyAwake_d__81.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MyAwake_d__81>.NativeClassPtr, "<>2__current");
				MapGenerator._MyAwake_d__81.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MyAwake_d__81>.NativeClassPtr, "<>4__this");
				MapGenerator._MyAwake_d__81.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._MyAwake_d__81>.NativeClassPtr, 100666225);
				MapGenerator._MyAwake_d__81.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._MyAwake_d__81>.NativeClassPtr, 100666226);
				MapGenerator._MyAwake_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._MyAwake_d__81>.NativeClassPtr, 100666227);
				MapGenerator._MyAwake_d__81.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._MyAwake_d__81>.NativeClassPtr, 100666228);
				MapGenerator._MyAwake_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._MyAwake_d__81>.NativeClassPtr, 100666229);
				MapGenerator._MyAwake_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._MyAwake_d__81>.NativeClassPtr, 100666230);
			}

			// Token: 0x06005132 RID: 20786 RVA: 0x00128188 File Offset: 0x00126388
			[CallerCount(0)]
			public unsafe _MyAwake_d__81(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapGenerator._MyAwake_d__81>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._MyAwake_d__81.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005133 RID: 20787 RVA: 0x001281D0 File Offset: 0x001263D0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._MyAwake_d__81.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005134 RID: 20788 RVA: 0x00128204 File Offset: 0x00126404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71307, XrefRangeEnd = 71334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._MyAwake_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D9B RID: 7579
			// (get) Token: 0x06005135 RID: 20789 RVA: 0x00128240 File Offset: 0x00126440
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._MyAwake_d__81.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005136 RID: 20790 RVA: 0x00128280 File Offset: 0x00126480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71334, XrefRangeEnd = 71339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._MyAwake_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D9C RID: 7580
			// (get) Token: 0x06005137 RID: 20791 RVA: 0x001282B4 File Offset: 0x001264B4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._MyAwake_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005138 RID: 20792 RVA: 0x0002F4E5 File Offset: 0x0002D6E5
			public _MyAwake_d__81(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D98 RID: 7576
			// (get) Token: 0x06005139 RID: 20793 RVA: 0x001282F4 File Offset: 0x001264F4
			// (set) Token: 0x0600513A RID: 20794 RVA: 0x0002F4EE File Offset: 0x0002D6EE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MyAwake_d__81.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MyAwake_d__81.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D99 RID: 7577
			// (get) Token: 0x0600513B RID: 20795 RVA: 0x0012831C File Offset: 0x0012651C
			// (set) Token: 0x0600513C RID: 20796 RVA: 0x0002F509 File Offset: 0x0002D709
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MyAwake_d__81.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MyAwake_d__81.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D9A RID: 7578
			// (get) Token: 0x0600513D RID: 20797 RVA: 0x0012834C File Offset: 0x0012654C
			// (set) Token: 0x0600513E RID: 20798 RVA: 0x0002F528 File Offset: 0x0002D728
			public unsafe MapGenerator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MyAwake_d__81.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MyAwake_d__81.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040035BF RID: 13759
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040035C0 RID: 13760
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040035C1 RID: 13761
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040035C2 RID: 13762
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040035C3 RID: 13763
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035C4 RID: 13764
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040035C5 RID: 13765
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040035C6 RID: 13766
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035C7 RID: 13767
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200032D RID: 813
		[ObfuscatedName("MapGenerator+<MakeIt>d__85")]
		public sealed class _MakeIt_d__85 : global::Il2CppSystem.Object
		{
			// Token: 0x0600513F RID: 20799 RVA: 0x0012837C File Offset: 0x0012657C
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeIt_d__85()
			{
				Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "<MakeIt>d__85");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr);
				MapGenerator._MakeIt_d__85.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, "<>1__state");
				MapGenerator._MakeIt_d__85.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, "<>2__current");
				MapGenerator._MakeIt_d__85.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, "<>4__this");
				MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, "<i>5__2");
				MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__minus_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, "<minus>5__3");
				MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__l_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, "<l>5__4");
				MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__completed_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, "<completed>5__5");
				MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__player_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, "<player>5__6");
				MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__j_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, "<j>5__7");
				MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__k_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, "<k>5__8");
				MapGenerator._MakeIt_d__85.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, 100666231);
				MapGenerator._MakeIt_d__85.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, 100666232);
				MapGenerator._MakeIt_d__85.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, 100666233);
				MapGenerator._MakeIt_d__85.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, 100666234);
				MapGenerator._MakeIt_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, 100666235);
				MapGenerator._MakeIt_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr, 100666236);
			}

			// Token: 0x06005140 RID: 20800 RVA: 0x001284E8 File Offset: 0x001266E8
			[CallerCount(0)]
			public unsafe _MakeIt_d__85(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapGenerator._MakeIt_d__85>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._MakeIt_d__85.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005141 RID: 20801 RVA: 0x00128530 File Offset: 0x00126730
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._MakeIt_d__85.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005142 RID: 20802 RVA: 0x00128564 File Offset: 0x00126764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71339, XrefRangeEnd = 71693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._MakeIt_d__85.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DA7 RID: 7591
			// (get) Token: 0x06005143 RID: 20803 RVA: 0x001285A0 File Offset: 0x001267A0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._MakeIt_d__85.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005144 RID: 20804 RVA: 0x001285E0 File Offset: 0x001267E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71693, XrefRangeEnd = 71698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._MakeIt_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DA8 RID: 7592
			// (get) Token: 0x06005145 RID: 20805 RVA: 0x00128614 File Offset: 0x00126814
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._MakeIt_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005146 RID: 20806 RVA: 0x0002F547 File Offset: 0x0002D747
			public _MakeIt_d__85(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D9D RID: 7581
			// (get) Token: 0x06005147 RID: 20807 RVA: 0x00128654 File Offset: 0x00126854
			// (set) Token: 0x06005148 RID: 20808 RVA: 0x0002F550 File Offset: 0x0002D750
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D9E RID: 7582
			// (get) Token: 0x06005149 RID: 20809 RVA: 0x0012867C File Offset: 0x0012687C
			// (set) Token: 0x0600514A RID: 20810 RVA: 0x0002F56B File Offset: 0x0002D76B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D9F RID: 7583
			// (get) Token: 0x0600514B RID: 20811 RVA: 0x001286AC File Offset: 0x001268AC
			// (set) Token: 0x0600514C RID: 20812 RVA: 0x0002F58A File Offset: 0x0002D78A
			public unsafe MapGenerator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DA0 RID: 7584
			// (get) Token: 0x0600514D RID: 20813 RVA: 0x001286DC File Offset: 0x001268DC
			// (set) Token: 0x0600514E RID: 20814 RVA: 0x0002F5A9 File Offset: 0x0002D7A9
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x17001DA1 RID: 7585
			// (get) Token: 0x0600514F RID: 20815 RVA: 0x00128704 File Offset: 0x00126904
			// (set) Token: 0x06005150 RID: 20816 RVA: 0x0002F5C4 File Offset: 0x0002D7C4
			public unsafe int _minus_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__minus_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__minus_5__3)) = value;
				}
			}

			// Token: 0x17001DA2 RID: 7586
			// (get) Token: 0x06005151 RID: 20817 RVA: 0x0012872C File Offset: 0x0012692C
			// (set) Token: 0x06005152 RID: 20818 RVA: 0x0002F5DF File Offset: 0x0002D7DF
			public unsafe int _l_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__l_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__l_5__4)) = value;
				}
			}

			// Token: 0x17001DA3 RID: 7587
			// (get) Token: 0x06005153 RID: 20819 RVA: 0x00128754 File Offset: 0x00126954
			// (set) Token: 0x06005154 RID: 20820 RVA: 0x0002F5FA File Offset: 0x0002D7FA
			public unsafe bool _completed_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__completed_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__completed_5__5)) = value;
				}
			}

			// Token: 0x17001DA4 RID: 7588
			// (get) Token: 0x06005155 RID: 20821 RVA: 0x0012877C File Offset: 0x0012697C
			// (set) Token: 0x06005156 RID: 20822 RVA: 0x0002F615 File Offset: 0x0002D815
			public unsafe GameObject _player_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__player_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__player_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DA5 RID: 7589
			// (get) Token: 0x06005157 RID: 20823 RVA: 0x001287AC File Offset: 0x001269AC
			// (set) Token: 0x06005158 RID: 20824 RVA: 0x0002F634 File Offset: 0x0002D834
			public unsafe int _j_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__j_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__j_5__7)) = value;
				}
			}

			// Token: 0x17001DA6 RID: 7590
			// (get) Token: 0x06005159 RID: 20825 RVA: 0x001287D4 File Offset: 0x001269D4
			// (set) Token: 0x0600515A RID: 20826 RVA: 0x0002F64F File Offset: 0x0002D84F
			public unsafe int _k_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__k_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._MakeIt_d__85.NativeFieldInfoPtr__k_5__8)) = value;
				}
			}

			// Token: 0x040035C8 RID: 13768
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040035C9 RID: 13769
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040035CA RID: 13770
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040035CB RID: 13771
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040035CC RID: 13772
			private static readonly IntPtr NativeFieldInfoPtr__minus_5__3;

			// Token: 0x040035CD RID: 13773
			private static readonly IntPtr NativeFieldInfoPtr__l_5__4;

			// Token: 0x040035CE RID: 13774
			private static readonly IntPtr NativeFieldInfoPtr__completed_5__5;

			// Token: 0x040035CF RID: 13775
			private static readonly IntPtr NativeFieldInfoPtr__player_5__6;

			// Token: 0x040035D0 RID: 13776
			private static readonly IntPtr NativeFieldInfoPtr__j_5__7;

			// Token: 0x040035D1 RID: 13777
			private static readonly IntPtr NativeFieldInfoPtr__k_5__8;

			// Token: 0x040035D2 RID: 13778
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040035D3 RID: 13779
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035D4 RID: 13780
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040035D5 RID: 13781
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040035D6 RID: 13782
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035D7 RID: 13783
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200032E RID: 814
		[ObfuscatedName("MapGenerator+<ReallyPlaceTiles>d__98")]
		public sealed class _ReallyPlaceTiles_d__98 : global::Il2CppSystem.Object
		{
			// Token: 0x0600515B RID: 20827 RVA: 0x001287FC File Offset: 0x001269FC
			// Note: this type is marked as 'beforefieldinit'.
			static _ReallyPlaceTiles_d__98()
			{
				Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapGenerator>.NativeClassPtr, "<ReallyPlaceTiles>d__98");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr);
				MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr, "<>1__state");
				MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr, "<>2__current");
				MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr, "<>4__this");
				MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr__j_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr, "<j>5__2");
				MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr, "<i>5__3");
				MapGenerator._ReallyPlaceTiles_d__98.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr, 100666237);
				MapGenerator._ReallyPlaceTiles_d__98.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr, 100666238);
				MapGenerator._ReallyPlaceTiles_d__98.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr, 100666239);
				MapGenerator._ReallyPlaceTiles_d__98.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr, 100666240);
				MapGenerator._ReallyPlaceTiles_d__98.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr, 100666241);
				MapGenerator._ReallyPlaceTiles_d__98.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr, 100666242);
			}

			// Token: 0x0600515C RID: 20828 RVA: 0x00128904 File Offset: 0x00126B04
			[CallerCount(0)]
			public unsafe _ReallyPlaceTiles_d__98(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapGenerator._ReallyPlaceTiles_d__98>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._ReallyPlaceTiles_d__98.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600515D RID: 20829 RVA: 0x0012894C File Offset: 0x00126B4C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._ReallyPlaceTiles_d__98.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600515E RID: 20830 RVA: 0x00128980 File Offset: 0x00126B80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71698, XrefRangeEnd = 71716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._ReallyPlaceTiles_d__98.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DAE RID: 7598
			// (get) Token: 0x0600515F RID: 20831 RVA: 0x001289BC File Offset: 0x00126BBC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._ReallyPlaceTiles_d__98.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005160 RID: 20832 RVA: 0x001289FC File Offset: 0x00126BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71716, XrefRangeEnd = 71721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._ReallyPlaceTiles_d__98.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DAF RID: 7599
			// (get) Token: 0x06005161 RID: 20833 RVA: 0x00128A30 File Offset: 0x00126C30
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapGenerator._ReallyPlaceTiles_d__98.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005162 RID: 20834 RVA: 0x0002F66A File Offset: 0x0002D86A
			public _ReallyPlaceTiles_d__98(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001DA9 RID: 7593
			// (get) Token: 0x06005163 RID: 20835 RVA: 0x00128A70 File Offset: 0x00126C70
			// (set) Token: 0x06005164 RID: 20836 RVA: 0x0002F673 File Offset: 0x0002D873
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DAA RID: 7594
			// (get) Token: 0x06005165 RID: 20837 RVA: 0x00128A98 File Offset: 0x00126C98
			// (set) Token: 0x06005166 RID: 20838 RVA: 0x0002F68E File Offset: 0x0002D88E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DAB RID: 7595
			// (get) Token: 0x06005167 RID: 20839 RVA: 0x00128AC8 File Offset: 0x00126CC8
			// (set) Token: 0x06005168 RID: 20840 RVA: 0x0002F6AD File Offset: 0x0002D8AD
			public unsafe MapGenerator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DAC RID: 7596
			// (get) Token: 0x06005169 RID: 20841 RVA: 0x00128AF8 File Offset: 0x00126CF8
			// (set) Token: 0x0600516A RID: 20842 RVA: 0x0002F6CC File Offset: 0x0002D8CC
			public unsafe int _j_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr__j_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr__j_5__2)) = value;
				}
			}

			// Token: 0x17001DAD RID: 7597
			// (get) Token: 0x0600516B RID: 20843 RVA: 0x00128B20 File Offset: 0x00126D20
			// (set) Token: 0x0600516C RID: 20844 RVA: 0x0002F6E7 File Offset: 0x0002D8E7
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapGenerator._ReallyPlaceTiles_d__98.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040035D8 RID: 13784
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040035D9 RID: 13785
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040035DA RID: 13786
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040035DB RID: 13787
			private static readonly IntPtr NativeFieldInfoPtr__j_5__2;

			// Token: 0x040035DC RID: 13788
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040035DD RID: 13789
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040035DE RID: 13790
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035DF RID: 13791
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040035E0 RID: 13792
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040035E1 RID: 13793
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035E2 RID: 13794
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
