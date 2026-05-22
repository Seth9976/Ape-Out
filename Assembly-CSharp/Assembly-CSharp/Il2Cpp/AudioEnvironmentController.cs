using System;
using Il2CppDG.Tweening;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001E RID: 30
	public class AudioEnvironmentController : MonoBehaviour
	{
		// Token: 0x06000406 RID: 1030 RVA: 0x0003F260 File Offset: 0x0003D460
		// Note: this type is marked as 'beforefieldinit'.
		static AudioEnvironmentController()
		{
			Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AudioEnvironmentController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr);
			AudioEnvironmentController.NativeFieldInfoPtr_Room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, "Room");
			AudioEnvironmentController.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, "me");
			AudioEnvironmentController.NativeFieldInfoPtr_currentPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, "currentPatch");
			AudioEnvironmentController.NativeFieldInfoPtr_ReverbZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, "ReverbZone");
			AudioEnvironmentController.NativeFieldInfoPtr_SECTRZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, "SECTRZone");
			AudioEnvironmentController.NativeFieldInfoPtr_inMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, "inMenu");
			AudioEnvironmentController.NativeFieldInfoPtr_overridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, "overridden");
			AudioEnvironmentController.NativeFieldInfoPtr_UsingResonance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, "UsingResonance");
			AudioEnvironmentController.NativeFieldInfoPtr_ambInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, "ambInt");
			AudioEnvironmentController.NativeFieldInfoPtr_prevLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, "prevLevel");
			AudioEnvironmentController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663577);
			AudioEnvironmentController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663578);
			AudioEnvironmentController.NativeMethodInfoPtr_InMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663579);
			AudioEnvironmentController.NativeMethodInfoPtr_Mute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663580);
			AudioEnvironmentController.NativeMethodInfoPtr_UnMute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663581);
			AudioEnvironmentController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663582);
			AudioEnvironmentController.NativeMethodInfoPtr_SetEnvironment_Public_Void_SECTR_AudioAmbience_ReverbPatch_ResonanceRoomPatch_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663583);
			AudioEnvironmentController.NativeMethodInfoPtr_SetNewAmbiance_Public_Void_SECTR_AudioAmbience_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663584);
			AudioEnvironmentController.NativeMethodInfoPtr_SetReverbZonePatch_Public_Void_ReverbPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663585);
			AudioEnvironmentController.NativeMethodInfoPtr_SetNewRoom_Public_Void_ResonanceRoomPatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663586);
			AudioEnvironmentController.NativeMethodInfoPtr_TransitionToNewRoom_Public_Void_ResonanceRoomPatch_Single_Ease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663587);
			AudioEnvironmentController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663588);
			AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_0_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663589);
			AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663590);
			AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_2_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663591);
			AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_3_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663592);
			AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_4_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663593);
			AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_5_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663594);
			AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_6_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663595);
			AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_7_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663596);
			AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_8_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663597);
			AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_9_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr, 100663598);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0003F510 File Offset: 0x0003D710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34411, XrefRangeEnd = 34420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0003F544 File Offset: 0x0003D744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34420, XrefRangeEnd = 34435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0003F578 File Offset: 0x0003D778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34435, XrefRangeEnd = 34437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InMenu(bool isInMenu)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isInMenu;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr_InMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0003F5B8 File Offset: 0x0003D7B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 34476, RefRangeEnd = 34479, XrefRangeStart = 34437, XrefRangeEnd = 34476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Mute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr_Mute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0003F5EC File Offset: 0x0003D7EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 34519, RefRangeEnd = 34524, XrefRangeStart = 34479, XrefRangeEnd = 34519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnMute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr_UnMute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0003F620 File Offset: 0x0003D820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34524, XrefRangeEnd = 34530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0003F654 File Offset: 0x0003D854
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 34573, RefRangeEnd = 34579, XrefRangeStart = 34530, XrefRangeEnd = 34573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnvironment(SECTR_AudioAmbience ambiance, ReverbPatch patch = null, ResonanceRoomPatch roomPatch = null, bool force = false, bool resetOverride = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ambiance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(patch);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roomPatch);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr_SetEnvironment_Public_Void_SECTR_AudioAmbience_ReverbPatch_ResonanceRoomPatch_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0003F6D8 File Offset: 0x0003D8D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34586, RefRangeEnd = 34588, XrefRangeStart = 34579, XrefRangeEnd = 34586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewAmbiance(SECTR_AudioAmbience ambiance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ambiance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr_SetNewAmbiance_Public_Void_SECTR_AudioAmbience_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0003F71C File Offset: 0x0003D91C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34641, RefRangeEnd = 34643, XrefRangeStart = 34588, XrefRangeEnd = 34641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReverbZonePatch(ReverbPatch patch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(patch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr_SetReverbZonePatch_Public_Void_ReverbPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0003F760 File Offset: 0x0003D960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34659, RefRangeEnd = 34660, XrefRangeStart = 34643, XrefRangeEnd = 34659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewRoom(ResonanceRoomPatch roomPatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(roomPatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr_SetNewRoom_Public_Void_ResonanceRoomPatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0003F7A4 File Offset: 0x0003D9A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34773, RefRangeEnd = 34774, XrefRangeStart = 34660, XrefRangeEnd = 34773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransitionToNewRoom(ResonanceRoomPatch roomPatch, float TransitionTime, Ease EaseType = Ease.OutQuad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(roomPatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TransitionTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref EaseType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr_TransitionToNewRoom_Public_Void_ResonanceRoomPatch_Single_Ease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0003F804 File Offset: 0x0003DA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioEnvironmentController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioEnvironmentController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0003F840 File Offset: 0x0003DA40
		[CallerCount(0)]
		public unsafe float _TransitionToNewRoom_b__20_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_0_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0003F87C File Offset: 0x0003DA7C
		[CallerCount(0)]
		public unsafe void _TransitionToNewRoom_b__20_1(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0003F8BC File Offset: 0x0003DABC
		[CallerCount(0)]
		public unsafe float _TransitionToNewRoom_b__20_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_2_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0003F8F8 File Offset: 0x0003DAF8
		[CallerCount(0)]
		public unsafe void _TransitionToNewRoom_b__20_3(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_3_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0003F938 File Offset: 0x0003DB38
		[CallerCount(0)]
		public unsafe float _TransitionToNewRoom_b__20_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_4_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0003F974 File Offset: 0x0003DB74
		[CallerCount(0)]
		public unsafe void _TransitionToNewRoom_b__20_5(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_5_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0003F9B4 File Offset: 0x0003DBB4
		[CallerCount(0)]
		public unsafe float _TransitionToNewRoom_b__20_6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_6_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0003F9F0 File Offset: 0x0003DBF0
		[CallerCount(0)]
		public unsafe void _TransitionToNewRoom_b__20_7(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_7_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0003FA30 File Offset: 0x0003DC30
		[CallerCount(0)]
		public unsafe Vector3 _TransitionToNewRoom_b__20_8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_8_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0003FA6C File Offset: 0x0003DC6C
		[CallerCount(0)]
		public unsafe void _TransitionToNewRoom_b__20_9(Vector3 x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioEnvironmentController.NativeMethodInfoPtr__TransitionToNewRoom_b__20_9_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00004AB9 File Offset: 0x00002CB9
		public AudioEnvironmentController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0003FAAC File Offset: 0x0003DCAC
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00004AC2 File Offset: 0x00002CC2
		public unsafe ResonanceAudioRoom Room
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_Room);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceAudioRoom>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_Room), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0003FADC File Offset: 0x0003DCDC
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00004AE1 File Offset: 0x00002CE1
		public unsafe static AudioEnvironmentController me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AudioEnvironmentController.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioEnvironmentController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioEnvironmentController.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0003FB04 File Offset: 0x0003DD04
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00004AF3 File Offset: 0x00002CF3
		public unsafe ResonanceRoomPatch currentPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_currentPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceRoomPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_currentPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0003FB34 File Offset: 0x0003DD34
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00004B12 File Offset: 0x00002D12
		public unsafe AudioReverbZone ReverbZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_ReverbZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioReverbZone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_ReverbZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0003FB64 File Offset: 0x0003DD64
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00004B31 File Offset: 0x00002D31
		public unsafe SECTR_AudioEnvironmentZone SECTRZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_SECTRZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioEnvironmentZone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_SECTRZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0003FB94 File Offset: 0x0003DD94
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00004B50 File Offset: 0x00002D50
		public unsafe bool inMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_inMenu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_inMenu)) = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0003FBBC File Offset: 0x0003DDBC
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00004B6B File Offset: 0x00002D6B
		public unsafe bool overridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_overridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_overridden)) = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0003FBE4 File Offset: 0x0003DDE4
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00004B86 File Offset: 0x00002D86
		public unsafe bool UsingResonance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_UsingResonance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_UsingResonance)) = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0003FC0C File Offset: 0x0003DE0C
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00004BA1 File Offset: 0x00002DA1
		public unsafe int ambInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_ambInt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_ambInt)) = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0003FC34 File Offset: 0x0003DE34
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00004BBC File Offset: 0x00002DBC
		public unsafe int prevLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_prevLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioEnvironmentController.NativeFieldInfoPtr_prevLevel)) = value;
			}
		}

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_Room;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_currentPatch;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_ReverbZone;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_SECTRZone;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr_inMenu;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr_overridden;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeFieldInfoPtr_UsingResonance;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeFieldInfoPtr_ambInt;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr_prevLevel;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_InMenu_Public_Void_Boolean_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_Mute_Public_Void_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_UnMute_Public_Void_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_SetEnvironment_Public_Void_SECTR_AudioAmbience_ReverbPatch_ResonanceRoomPatch_Boolean_Boolean_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_SetNewAmbiance_Public_Void_SECTR_AudioAmbience_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_SetReverbZonePatch_Public_Void_ReverbPatch_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_SetNewRoom_Public_Void_ResonanceRoomPatch_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_TransitionToNewRoom_Public_Void_ResonanceRoomPatch_Single_Ease_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr__TransitionToNewRoom_b__20_0_Private_Single_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr__TransitionToNewRoom_b__20_1_Private_Void_Single_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr__TransitionToNewRoom_b__20_2_Private_Single_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr__TransitionToNewRoom_b__20_3_Private_Void_Single_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr__TransitionToNewRoom_b__20_4_Private_Single_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr__TransitionToNewRoom_b__20_5_Private_Void_Single_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr__TransitionToNewRoom_b__20_6_Private_Single_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr__TransitionToNewRoom_b__20_7_Private_Void_Single_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr__TransitionToNewRoom_b__20_8_Private_Vector3_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr__TransitionToNewRoom_b__20_9_Private_Void_Vector3_0;
	}
}
