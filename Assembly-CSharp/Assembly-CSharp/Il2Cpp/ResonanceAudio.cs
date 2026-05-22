using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000013 RID: 19
	public static class ResonanceAudio : global::Il2CppSystem.Object
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x0003B488 File Offset: 0x00039688
		// Note: this type is marked as 'beforefieldinit'.
		static ResonanceAudio()
		{
			Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResonanceAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr);
			ResonanceAudio.NativeFieldInfoPtr_listenerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "listenerTransform");
			ResonanceAudio.NativeFieldInfoPtr_inMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "inMenu");
			ResonanceAudio.NativeFieldInfoPtr_listenerDirectivityColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "listenerDirectivityColor");
			ResonanceAudio.NativeFieldInfoPtr_sourceDirectivityColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "sourceDirectivityColor");
			ResonanceAudio.NativeFieldInfoPtr_distanceEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "distanceEpsilon");
			ResonanceAudio.NativeFieldInfoPtr_maxDistanceLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "maxDistanceLimit");
			ResonanceAudio.NativeFieldInfoPtr_minDistanceLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "minDistanceLimit");
			ResonanceAudio.NativeFieldInfoPtr_maxGainDb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "maxGainDb");
			ResonanceAudio.NativeFieldInfoPtr_minGainDb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "minGainDb");
			ResonanceAudio.NativeFieldInfoPtr_maxReverbBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "maxReverbBrightness");
			ResonanceAudio.NativeFieldInfoPtr_minReverbBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "minReverbBrightness");
			ResonanceAudio.NativeFieldInfoPtr_maxReverbTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "maxReverbTime");
			ResonanceAudio.NativeFieldInfoPtr_maxReflectivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "maxReflectivity");
			ResonanceAudio.NativeFieldInfoPtr_maxNumOcclusionHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "maxNumOcclusionHits");
			ResonanceAudio.NativeFieldInfoPtr_occlusionDetectionInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "occlusionDetectionInterval");
			ResonanceAudio.NativeFieldInfoPtr_flipZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "flipZ");
			ResonanceAudio.NativeFieldInfoPtr_occlusionHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "occlusionHits");
			ResonanceAudio.NativeFieldInfoPtr_occlusionMaskValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "occlusionMaskValue");
			ResonanceAudio.NativeFieldInfoPtr_roomProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "roomProperties");
			ResonanceAudio.NativeFieldInfoPtr_roomPropertiesPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "roomPropertiesPtr");
			ResonanceAudio.NativeFieldInfoPtr_transformMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "transformMatrix");
			ResonanceAudio.NativeFieldInfoPtr_pluginName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "pluginName");
			ResonanceAudio.NativeMethodInfoPtr_get_ListenerTransform_Public_Static_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663441);
			ResonanceAudio.NativeMethodInfoPtr_UpdateAudioListener_Public_Static_Void_ResonanceAudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663442);
			ResonanceAudio.NativeMethodInfoPtr_DisableRoomEffects_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663443);
			ResonanceAudio.NativeMethodInfoPtr_UpdateRoom_Public_Static_Void_ResonanceAudioRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663444);
			ResonanceAudio.NativeMethodInfoPtr_UpdateReverbProbe_Public_Static_Void_ResonanceAudioReverbProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663445);
			ResonanceAudio.NativeMethodInfoPtr_StartRecording_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663446);
			ResonanceAudio.NativeMethodInfoPtr_StopRecordingAndSaveToFile_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663447);
			ResonanceAudio.NativeMethodInfoPtr_InitializeReverbComputer_Public_Static_Void_Il2CppStructArray_1_Single_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663448);
			ResonanceAudio.NativeMethodInfoPtr_ComputeRt60sAndProxyRoom_Public_Static_Boolean_ResonanceAudioReverbProbe_Int32_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663449);
			ResonanceAudio.NativeMethodInfoPtr_InMenu_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663450);
			ResonanceAudio.NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663451);
			ResonanceAudio.NativeMethodInfoPtr_ConvertAmplitudeFromDb_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663452);
			ResonanceAudio.NativeMethodInfoPtr_Generate2dPolarPattern_Public_Static_Il2CppStructArray_1_Vector2_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663453);
			ResonanceAudio.NativeMethodInfoPtr_ConvertAudioTransformFromUnity_Private_Static_Void_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663454);
			ResonanceAudio.NativeMethodInfoPtr_SetProxyRoomProperties_Private_Static_Void_ResonanceAudioReverbProbe_RoomProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663455);
			ResonanceAudio.NativeMethodInfoPtr_UpdateRoomProperties_Private_Static_Void_ResonanceAudioRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663456);
			ResonanceAudio.NativeMethodInfoPtr_UpdateRoomProperties_Private_Static_Void_ResonanceAudioReverbProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663457);
			ResonanceAudio.NativeMethodInfoPtr_FillGeometryOfRoomProperties_Private_Static_Void_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663458);
			ResonanceAudio.NativeMethodInfoPtr_FillWallMaterialsOfRoomProperties_Private_Static_Void_SurfaceMaterial_SurfaceMaterial_SurfaceMaterial_SurfaceMaterial_SurfaceMaterial_SurfaceMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663459);
			ResonanceAudio.NativeMethodInfoPtr_FillModifiersOfRoomProperties_Private_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663460);
			ResonanceAudio.NativeMethodInfoPtr_SetListenerGain_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663461);
			ResonanceAudio.NativeMethodInfoPtr_SetListenerStereoSpeakerMode_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663462);
			ResonanceAudio.NativeMethodInfoPtr_SetRoomProperties_Private_Static_Void_IntPtr_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, 100663463);
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0003B83C File Offset: 0x00039A3C
		public unsafe static Transform ListenerTransform
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 32866, RefRangeEnd = 32869, XrefRangeStart = 32827, XrefRangeEnd = 32866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_get_ListenerTransform_Public_Static_get_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0003B870 File Offset: 0x00039A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32869, XrefRangeEnd = 32879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateAudioListener(ResonanceAudioListener listener)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_UpdateAudioListener_Public_Static_Void_ResonanceAudioListener_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0003B8A8 File Offset: 0x00039AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32879, XrefRangeEnd = 32892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableRoomEffects()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_DisableRoomEffects_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0003B8D0 File Offset: 0x00039AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32933, RefRangeEnd = 32934, XrefRangeStart = 32892, XrefRangeEnd = 32933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateRoom(ResonanceAudioRoom room)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(room);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_UpdateRoom_Public_Static_Void_ResonanceAudioRoom_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0003B908 File Offset: 0x00039B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32934, XrefRangeEnd = 32981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateReverbProbe(ResonanceAudioReverbProbe reverbPobe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reverbPobe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_UpdateReverbProbe_Public_Static_Void_ResonanceAudioReverbProbe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0003B940 File Offset: 0x00039B40
		[CallerCount(0)]
		public unsafe static bool StartRecording()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_StartRecording_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0003B970 File Offset: 0x00039B70
		[CallerCount(0)]
		public unsafe static bool StopRecordingAndSaveToFile(string filePath, bool seamless)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seamless;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_StopRecordingAndSaveToFile_Public_Static_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0003B9C0 File Offset: 0x00039BC0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeReverbComputer(Il2CppStructArray<float> vertices, Il2CppStructArray<int> triangles, Il2CppStructArray<int> materialIndices, float scatteringCoefficient)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(materialIndices);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scatteringCoefficient;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_InitializeReverbComputer_Public_Static_Void_Il2CppStructArray_1_Single_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0003BA28 File Offset: 0x00039C28
		[CallerCount(0)]
		public unsafe static bool ComputeRt60sAndProxyRoom(ResonanceAudioReverbProbe reverbProbe, int totalNumPaths, int numPathsPerBatch, int maxDepth, float energyThreshold, float listenerSphereRadius)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reverbProbe);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalNumPaths;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPathsPerBatch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref energyThreshold;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listenerSphereRadius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_ComputeRt60sAndProxyRoom_Public_Static_Boolean_ResonanceAudioReverbProbe_Int32_Int32_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0003BAB0 File Offset: 0x00039CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32981, XrefRangeEnd = 32985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InMenu(bool isInMenu)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isInMenu;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_InMenu_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0003BAE4 File Offset: 0x00039CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32985, XrefRangeEnd = 33032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ComputeOcclusion(Transform sourceTransform)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Single_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0003BB28 File Offset: 0x00039D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33032, XrefRangeEnd = 33033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ConvertAmplitudeFromDb(float db)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref db;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_ConvertAmplitudeFromDb_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0003BB68 File Offset: 0x00039D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33033, XrefRangeEnd = 33039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector2> Generate2dPolarPattern(float alpha, float order, int resolution)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_Generate2dPolarPattern_Public_Static_Il2CppStructArray_1_Vector2_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0003BBC4 File Offset: 0x00039DC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33055, RefRangeEnd = 33056, XrefRangeStart = 33039, XrefRangeEnd = 33055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertAudioTransformFromUnity(ref Vector3 position, ref Quaternion rotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_ConvertAudioTransformFromUnity_Private_Static_Void_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0003BC04 File Offset: 0x00039E04
		[CallerCount(0)]
		public unsafe static void SetProxyRoomProperties(ResonanceAudioReverbProbe reverbProbe, ResonanceAudio.RoomProperties proxyRoomProperties)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reverbProbe);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxyRoomProperties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_SetProxyRoomProperties_Private_Static_Void_ResonanceAudioReverbProbe_RoomProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0003BC4C File Offset: 0x00039E4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33074, RefRangeEnd = 33075, XrefRangeStart = 33056, XrefRangeEnd = 33074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateRoomProperties(ResonanceAudioRoom room)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(room);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_UpdateRoomProperties_Private_Static_Void_ResonanceAudioRoom_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0003BC84 File Offset: 0x00039E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33075, XrefRangeEnd = 33081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateRoomProperties(ResonanceAudioReverbProbe reverbProbe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reverbProbe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_UpdateRoomProperties_Private_Static_Void_ResonanceAudioReverbProbe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0003BCBC File Offset: 0x00039EBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 33095, RefRangeEnd = 33098, XrefRangeStart = 33081, XrefRangeEnd = 33095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillGeometryOfRoomProperties(Vector3 position, Quaternion rotation, Vector3 scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_FillGeometryOfRoomProperties_Private_Static_Void_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0003BD0C File Offset: 0x00039F0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 33107, RefRangeEnd = 33110, XrefRangeStart = 33098, XrefRangeEnd = 33107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillWallMaterialsOfRoomProperties(ResonanceAudioRoomManager.SurfaceMaterial leftWall, ResonanceAudioRoomManager.SurfaceMaterial rightWall, ResonanceAudioRoomManager.SurfaceMaterial floor, ResonanceAudioRoomManager.SurfaceMaterial ceiling, ResonanceAudioRoomManager.SurfaceMaterial frontWall, ResonanceAudioRoomManager.SurfaceMaterial backWall)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref leftWall;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightWall;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ceiling;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frontWall;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backWall;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_FillWallMaterialsOfRoomProperties_Private_Static_Void_SurfaceMaterial_SurfaceMaterial_SurfaceMaterial_SurfaceMaterial_SurfaceMaterial_SurfaceMaterial_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0003BD84 File Offset: 0x00039F84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 33118, RefRangeEnd = 33121, XrefRangeStart = 33110, XrefRangeEnd = 33118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillModifiersOfRoomProperties(float reverbGainDb, float reverbTime, float reverbBrightness, float reflectivity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reverbGainDb;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverbTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverbBrightness;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reflectivity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_FillModifiersOfRoomProperties_Private_Static_Void_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0003BDE0 File Offset: 0x00039FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33121, XrefRangeEnd = 33123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetListenerGain(float gain)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gain;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_SetListenerGain_Private_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0003BE14 File Offset: 0x0003A014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33123, XrefRangeEnd = 33125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetListenerStereoSpeakerMode(bool enableStereoSpeakerMode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enableStereoSpeakerMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_SetListenerStereoSpeakerMode_Private_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0003BE48 File Offset: 0x0003A048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33125, XrefRangeEnd = 33146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRoomProperties(IntPtr roomProperties, Il2CppStructArray<float> rt60s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref roomProperties;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rt60s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.NativeMethodInfoPtr_SetRoomProperties_Private_Static_Void_IntPtr_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000413B File Offset: 0x0000233B
		public ResonanceAudio(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0003BE8C File Offset: 0x0003A08C
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00004144 File Offset: 0x00002344
		public unsafe static Transform listenerTransform
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_listenerTransform, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_listenerTransform, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0003BEB4 File Offset: 0x0003A0B4
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00004156 File Offset: 0x00002356
		public unsafe static bool inMenu
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_inMenu, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_inMenu, (void*)(&value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0003BED0 File Offset: 0x0003A0D0
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00004164 File Offset: 0x00002364
		public unsafe static Color listenerDirectivityColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_listenerDirectivityColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_listenerDirectivityColor, (void*)(&value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0003BEEC File Offset: 0x0003A0EC
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x00004172 File Offset: 0x00002372
		public unsafe static Color sourceDirectivityColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_sourceDirectivityColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_sourceDirectivityColor, (void*)(&value));
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0003BF08 File Offset: 0x0003A108
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00004180 File Offset: 0x00002380
		public unsafe static float distanceEpsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_distanceEpsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_distanceEpsilon, (void*)(&value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0003BF24 File Offset: 0x0003A124
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0000418E File Offset: 0x0000238E
		public unsafe static float maxDistanceLimit
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_maxDistanceLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_maxDistanceLimit, (void*)(&value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0003BF40 File Offset: 0x0003A140
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0000419C File Offset: 0x0000239C
		public unsafe static float minDistanceLimit
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_minDistanceLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_minDistanceLimit, (void*)(&value));
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0003BF5C File Offset: 0x0003A15C
		// (set) Token: 0x060002EA RID: 746 RVA: 0x000041AA File Offset: 0x000023AA
		public unsafe static float maxGainDb
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_maxGainDb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_maxGainDb, (void*)(&value));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0003BF78 File Offset: 0x0003A178
		// (set) Token: 0x060002EC RID: 748 RVA: 0x000041B8 File Offset: 0x000023B8
		public unsafe static float minGainDb
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_minGainDb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_minGainDb, (void*)(&value));
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0003BF94 File Offset: 0x0003A194
		// (set) Token: 0x060002EE RID: 750 RVA: 0x000041C6 File Offset: 0x000023C6
		public unsafe static float maxReverbBrightness
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_maxReverbBrightness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_maxReverbBrightness, (void*)(&value));
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0003BFB0 File Offset: 0x0003A1B0
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x000041D4 File Offset: 0x000023D4
		public unsafe static float minReverbBrightness
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_minReverbBrightness, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_minReverbBrightness, (void*)(&value));
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0003BFCC File Offset: 0x0003A1CC
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x000041E2 File Offset: 0x000023E2
		public unsafe static float maxReverbTime
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_maxReverbTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_maxReverbTime, (void*)(&value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0003BFE8 File Offset: 0x0003A1E8
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x000041F0 File Offset: 0x000023F0
		public unsafe static float maxReflectivity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_maxReflectivity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_maxReflectivity, (void*)(&value));
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0003C004 File Offset: 0x0003A204
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x000041FE File Offset: 0x000023FE
		public unsafe static int maxNumOcclusionHits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_maxNumOcclusionHits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_maxNumOcclusionHits, (void*)(&value));
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0003C020 File Offset: 0x0003A220
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x0000420C File Offset: 0x0000240C
		public unsafe static float occlusionDetectionInterval
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_occlusionDetectionInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_occlusionDetectionInterval, (void*)(&value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0003C03C File Offset: 0x0003A23C
		// (set) Token: 0x060002FA RID: 762 RVA: 0x0000421A File Offset: 0x0000241A
		public unsafe static Matrix4x4 flipZ
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_flipZ, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_flipZ, (void*)(&value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0003C058 File Offset: 0x0003A258
		// (set) Token: 0x060002FC RID: 764 RVA: 0x00004228 File Offset: 0x00002428
		public unsafe static Il2CppStructArray<RaycastHit2D> occlusionHits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_occlusionHits, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_occlusionHits, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0003C080 File Offset: 0x0003A280
		// (set) Token: 0x060002FE RID: 766 RVA: 0x0000423A File Offset: 0x0000243A
		public unsafe static int occlusionMaskValue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_occlusionMaskValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_occlusionMaskValue, (void*)(&value));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0003C09C File Offset: 0x0003A29C
		// (set) Token: 0x06000300 RID: 768 RVA: 0x00004248 File Offset: 0x00002448
		public unsafe static ResonanceAudio.RoomProperties roomProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_roomProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceAudio.RoomProperties>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_roomProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0003C0C4 File Offset: 0x0003A2C4
		// (set) Token: 0x06000302 RID: 770 RVA: 0x0000425A File Offset: 0x0000245A
		public unsafe static IntPtr roomPropertiesPtr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_roomPropertiesPtr, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_roomPropertiesPtr, (void*)(&value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0003C0E0 File Offset: 0x0003A2E0
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00004268 File Offset: 0x00002468
		public unsafe static Matrix4x4 transformMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_transformMatrix, (void*)(&matrix4x));
				return matrix4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_transformMatrix, (void*)(&value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0003C0FC File Offset: 0x0003A2FC
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00004276 File Offset: 0x00002476
		public unsafe static string pluginName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ResonanceAudio.NativeFieldInfoPtr_pluginName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResonanceAudio.NativeFieldInfoPtr_pluginName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_listenerTransform;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_inMenu;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_listenerDirectivityColor;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_sourceDirectivityColor;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_distanceEpsilon;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_maxDistanceLimit;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_minDistanceLimit;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_maxGainDb;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_minGainDb;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_maxReverbBrightness;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_minReverbBrightness;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_maxReverbTime;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_maxReflectivity;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_maxNumOcclusionHits;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_occlusionDetectionInterval;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_flipZ;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_occlusionHits;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_occlusionMaskValue;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_roomProperties;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr_roomPropertiesPtr;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeFieldInfoPtr_transformMatrix;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeFieldInfoPtr_pluginName;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_get_ListenerTransform_Public_Static_get_Transform_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAudioListener_Public_Static_Void_ResonanceAudioListener_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_DisableRoomEffects_Public_Static_Void_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRoom_Public_Static_Void_ResonanceAudioRoom_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_UpdateReverbProbe_Public_Static_Void_ResonanceAudioReverbProbe_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_StartRecording_Public_Static_Boolean_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_StopRecordingAndSaveToFile_Public_Static_Boolean_String_Boolean_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_InitializeReverbComputer_Public_Static_Void_Il2CppStructArray_1_Single_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Single_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_ComputeRt60sAndProxyRoom_Public_Static_Boolean_ResonanceAudioReverbProbe_Int32_Int32_Int32_Single_Single_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_InMenu_Public_Static_Void_Boolean_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Single_Transform_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_ConvertAmplitudeFromDb_Public_Static_Single_Single_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_Generate2dPolarPattern_Public_Static_Il2CppStructArray_1_Vector2_Single_Single_Int32_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_ConvertAudioTransformFromUnity_Private_Static_Void_byref_Vector3_byref_Quaternion_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_SetProxyRoomProperties_Private_Static_Void_ResonanceAudioReverbProbe_RoomProperties_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRoomProperties_Private_Static_Void_ResonanceAudioRoom_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRoomProperties_Private_Static_Void_ResonanceAudioReverbProbe_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_FillGeometryOfRoomProperties_Private_Static_Void_Vector3_Quaternion_Vector3_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_FillWallMaterialsOfRoomProperties_Private_Static_Void_SurfaceMaterial_SurfaceMaterial_SurfaceMaterial_SurfaceMaterial_SurfaceMaterial_SurfaceMaterial_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_FillModifiersOfRoomProperties_Private_Static_Void_Single_Single_Single_Single_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_SetListenerGain_Private_Static_Void_Single_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_SetListenerStereoSpeakerMode_Private_Static_Void_Boolean_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_SetRoomProperties_Private_Static_Void_IntPtr_Il2CppStructArray_1_Single_0;

		// Token: 0x0200029C RID: 668
		public class RoomProperties : global::Il2CppSystem.Object
		{
			// Token: 0x06004A34 RID: 18996 RVA: 0x0011340C File Offset: 0x0011160C
			// Note: this type is marked as 'beforefieldinit'.
			static RoomProperties()
			{
				Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResonanceAudio>.NativeClassPtr, "RoomProperties");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr);
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_positionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "positionX");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_positionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "positionY");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_positionZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "positionZ");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_rotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "rotationX");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_rotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "rotationY");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_rotationZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "rotationZ");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_rotationW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "rotationW");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_dimensionsX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "dimensionsX");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_dimensionsY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "dimensionsY");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_dimensionsZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "dimensionsZ");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "materialLeft");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "materialRight");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "materialBottom");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "materialTop");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "materialFront");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "materialBack");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_reflectionScalar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "reflectionScalar");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_reverbGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "reverbGain");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_reverbTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "reverbTime");
				ResonanceAudio.RoomProperties.NativeFieldInfoPtr_reverbBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, "reverbBrightness");
				ResonanceAudio.RoomProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr, 100663465);
			}

			// Token: 0x06004A35 RID: 18997 RVA: 0x001135DC File Offset: 0x001117DC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RoomProperties()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudio.RoomProperties>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudio.RoomProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A36 RID: 18998 RVA: 0x0002BB0C File Offset: 0x00029D0C
			public RoomProperties(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AFE RID: 6910
			// (get) Token: 0x06004A37 RID: 18999 RVA: 0x00113618 File Offset: 0x00111818
			// (set) Token: 0x06004A38 RID: 19000 RVA: 0x0002BB15 File Offset: 0x00029D15
			public unsafe float positionX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_positionX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_positionX)) = value;
				}
			}

			// Token: 0x17001AFF RID: 6911
			// (get) Token: 0x06004A39 RID: 19001 RVA: 0x00113640 File Offset: 0x00111840
			// (set) Token: 0x06004A3A RID: 19002 RVA: 0x0002BB30 File Offset: 0x00029D30
			public unsafe float positionY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_positionY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_positionY)) = value;
				}
			}

			// Token: 0x17001B00 RID: 6912
			// (get) Token: 0x06004A3B RID: 19003 RVA: 0x00113668 File Offset: 0x00111868
			// (set) Token: 0x06004A3C RID: 19004 RVA: 0x0002BB4B File Offset: 0x00029D4B
			public unsafe float positionZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_positionZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_positionZ)) = value;
				}
			}

			// Token: 0x17001B01 RID: 6913
			// (get) Token: 0x06004A3D RID: 19005 RVA: 0x00113690 File Offset: 0x00111890
			// (set) Token: 0x06004A3E RID: 19006 RVA: 0x0002BB66 File Offset: 0x00029D66
			public unsafe float rotationX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_rotationX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_rotationX)) = value;
				}
			}

			// Token: 0x17001B02 RID: 6914
			// (get) Token: 0x06004A3F RID: 19007 RVA: 0x001136B8 File Offset: 0x001118B8
			// (set) Token: 0x06004A40 RID: 19008 RVA: 0x0002BB81 File Offset: 0x00029D81
			public unsafe float rotationY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_rotationY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_rotationY)) = value;
				}
			}

			// Token: 0x17001B03 RID: 6915
			// (get) Token: 0x06004A41 RID: 19009 RVA: 0x001136E0 File Offset: 0x001118E0
			// (set) Token: 0x06004A42 RID: 19010 RVA: 0x0002BB9C File Offset: 0x00029D9C
			public unsafe float rotationZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_rotationZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_rotationZ)) = value;
				}
			}

			// Token: 0x17001B04 RID: 6916
			// (get) Token: 0x06004A43 RID: 19011 RVA: 0x00113708 File Offset: 0x00111908
			// (set) Token: 0x06004A44 RID: 19012 RVA: 0x0002BBB7 File Offset: 0x00029DB7
			public unsafe float rotationW
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_rotationW);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_rotationW)) = value;
				}
			}

			// Token: 0x17001B05 RID: 6917
			// (get) Token: 0x06004A45 RID: 19013 RVA: 0x00113730 File Offset: 0x00111930
			// (set) Token: 0x06004A46 RID: 19014 RVA: 0x0002BBD2 File Offset: 0x00029DD2
			public unsafe float dimensionsX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_dimensionsX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_dimensionsX)) = value;
				}
			}

			// Token: 0x17001B06 RID: 6918
			// (get) Token: 0x06004A47 RID: 19015 RVA: 0x00113758 File Offset: 0x00111958
			// (set) Token: 0x06004A48 RID: 19016 RVA: 0x0002BBED File Offset: 0x00029DED
			public unsafe float dimensionsY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_dimensionsY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_dimensionsY)) = value;
				}
			}

			// Token: 0x17001B07 RID: 6919
			// (get) Token: 0x06004A49 RID: 19017 RVA: 0x00113780 File Offset: 0x00111980
			// (set) Token: 0x06004A4A RID: 19018 RVA: 0x0002BC08 File Offset: 0x00029E08
			public unsafe float dimensionsZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_dimensionsZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_dimensionsZ)) = value;
				}
			}

			// Token: 0x17001B08 RID: 6920
			// (get) Token: 0x06004A4B RID: 19019 RVA: 0x001137A8 File Offset: 0x001119A8
			// (set) Token: 0x06004A4C RID: 19020 RVA: 0x0002BC23 File Offset: 0x00029E23
			public unsafe ResonanceAudioRoomManager.SurfaceMaterial materialLeft
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialLeft);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialLeft)) = value;
				}
			}

			// Token: 0x17001B09 RID: 6921
			// (get) Token: 0x06004A4D RID: 19021 RVA: 0x001137D0 File Offset: 0x001119D0
			// (set) Token: 0x06004A4E RID: 19022 RVA: 0x0002BC3E File Offset: 0x00029E3E
			public unsafe ResonanceAudioRoomManager.SurfaceMaterial materialRight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialRight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialRight)) = value;
				}
			}

			// Token: 0x17001B0A RID: 6922
			// (get) Token: 0x06004A4F RID: 19023 RVA: 0x001137F8 File Offset: 0x001119F8
			// (set) Token: 0x06004A50 RID: 19024 RVA: 0x0002BC59 File Offset: 0x00029E59
			public unsafe ResonanceAudioRoomManager.SurfaceMaterial materialBottom
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialBottom);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialBottom)) = value;
				}
			}

			// Token: 0x17001B0B RID: 6923
			// (get) Token: 0x06004A51 RID: 19025 RVA: 0x00113820 File Offset: 0x00111A20
			// (set) Token: 0x06004A52 RID: 19026 RVA: 0x0002BC74 File Offset: 0x00029E74
			public unsafe ResonanceAudioRoomManager.SurfaceMaterial materialTop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialTop);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialTop)) = value;
				}
			}

			// Token: 0x17001B0C RID: 6924
			// (get) Token: 0x06004A53 RID: 19027 RVA: 0x00113848 File Offset: 0x00111A48
			// (set) Token: 0x06004A54 RID: 19028 RVA: 0x0002BC8F File Offset: 0x00029E8F
			public unsafe ResonanceAudioRoomManager.SurfaceMaterial materialFront
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialFront);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialFront)) = value;
				}
			}

			// Token: 0x17001B0D RID: 6925
			// (get) Token: 0x06004A55 RID: 19029 RVA: 0x00113870 File Offset: 0x00111A70
			// (set) Token: 0x06004A56 RID: 19030 RVA: 0x0002BCAA File Offset: 0x00029EAA
			public unsafe ResonanceAudioRoomManager.SurfaceMaterial materialBack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialBack);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_materialBack)) = value;
				}
			}

			// Token: 0x17001B0E RID: 6926
			// (get) Token: 0x06004A57 RID: 19031 RVA: 0x00113898 File Offset: 0x00111A98
			// (set) Token: 0x06004A58 RID: 19032 RVA: 0x0002BCC5 File Offset: 0x00029EC5
			public unsafe float reflectionScalar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_reflectionScalar);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_reflectionScalar)) = value;
				}
			}

			// Token: 0x17001B0F RID: 6927
			// (get) Token: 0x06004A59 RID: 19033 RVA: 0x001138C0 File Offset: 0x00111AC0
			// (set) Token: 0x06004A5A RID: 19034 RVA: 0x0002BCE0 File Offset: 0x00029EE0
			public unsafe float reverbGain
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_reverbGain);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_reverbGain)) = value;
				}
			}

			// Token: 0x17001B10 RID: 6928
			// (get) Token: 0x06004A5B RID: 19035 RVA: 0x001138E8 File Offset: 0x00111AE8
			// (set) Token: 0x06004A5C RID: 19036 RVA: 0x0002BCFB File Offset: 0x00029EFB
			public unsafe float reverbTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_reverbTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_reverbTime)) = value;
				}
			}

			// Token: 0x17001B11 RID: 6929
			// (get) Token: 0x06004A5D RID: 19037 RVA: 0x00113910 File Offset: 0x00111B10
			// (set) Token: 0x06004A5E RID: 19038 RVA: 0x0002BD16 File Offset: 0x00029F16
			public unsafe float reverbBrightness
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_reverbBrightness);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudio.RoomProperties.NativeFieldInfoPtr_reverbBrightness)) = value;
				}
			}

			// Token: 0x04003053 RID: 12371
			private static readonly IntPtr NativeFieldInfoPtr_positionX;

			// Token: 0x04003054 RID: 12372
			private static readonly IntPtr NativeFieldInfoPtr_positionY;

			// Token: 0x04003055 RID: 12373
			private static readonly IntPtr NativeFieldInfoPtr_positionZ;

			// Token: 0x04003056 RID: 12374
			private static readonly IntPtr NativeFieldInfoPtr_rotationX;

			// Token: 0x04003057 RID: 12375
			private static readonly IntPtr NativeFieldInfoPtr_rotationY;

			// Token: 0x04003058 RID: 12376
			private static readonly IntPtr NativeFieldInfoPtr_rotationZ;

			// Token: 0x04003059 RID: 12377
			private static readonly IntPtr NativeFieldInfoPtr_rotationW;

			// Token: 0x0400305A RID: 12378
			private static readonly IntPtr NativeFieldInfoPtr_dimensionsX;

			// Token: 0x0400305B RID: 12379
			private static readonly IntPtr NativeFieldInfoPtr_dimensionsY;

			// Token: 0x0400305C RID: 12380
			private static readonly IntPtr NativeFieldInfoPtr_dimensionsZ;

			// Token: 0x0400305D RID: 12381
			private static readonly IntPtr NativeFieldInfoPtr_materialLeft;

			// Token: 0x0400305E RID: 12382
			private static readonly IntPtr NativeFieldInfoPtr_materialRight;

			// Token: 0x0400305F RID: 12383
			private static readonly IntPtr NativeFieldInfoPtr_materialBottom;

			// Token: 0x04003060 RID: 12384
			private static readonly IntPtr NativeFieldInfoPtr_materialTop;

			// Token: 0x04003061 RID: 12385
			private static readonly IntPtr NativeFieldInfoPtr_materialFront;

			// Token: 0x04003062 RID: 12386
			private static readonly IntPtr NativeFieldInfoPtr_materialBack;

			// Token: 0x04003063 RID: 12387
			private static readonly IntPtr NativeFieldInfoPtr_reflectionScalar;

			// Token: 0x04003064 RID: 12388
			private static readonly IntPtr NativeFieldInfoPtr_reverbGain;

			// Token: 0x04003065 RID: 12389
			private static readonly IntPtr NativeFieldInfoPtr_reverbTime;

			// Token: 0x04003066 RID: 12390
			private static readonly IntPtr NativeFieldInfoPtr_reverbBrightness;

			// Token: 0x04003067 RID: 12391
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
