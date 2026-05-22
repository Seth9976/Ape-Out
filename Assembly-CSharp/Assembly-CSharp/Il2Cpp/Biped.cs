using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200007A RID: 122
	public class Biped : Legs
	{
		// Token: 0x06000FC2 RID: 4034 RVA: 0x0006240C File Offset: 0x0006060C
		// Note: this type is marked as 'beforefieldinit'.
		static Biped()
		{
			Il2CppClassPointerStore<Biped>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Biped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Biped>.NativeClassPtr);
			Biped.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "state");
			Biped.NativeFieldInfoPtr_maxHipDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "maxHipDist");
			Biped.NativeFieldInfoPtr_rightVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "rightVect");
			Biped.NativeFieldInfoPtr_backVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "backVect");
			Biped.NativeFieldInfoPtr_trueFPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "trueFPos");
			Biped.NativeFieldInfoPtr_trueHPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "trueHPos");
			Biped.NativeFieldInfoPtr_prevHipsPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "prevHipsPos");
			Biped.NativeFieldInfoPtr_gapFiller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "gapFiller");
			Biped.NativeFieldInfoPtr_hipPts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "hipPts");
			Biped.NativeFieldInfoPtr_chestPts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "chestPts");
			Biped.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "pts");
			Biped.NativeFieldInfoPtr_renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "renderers");
			Biped.NativeFieldInfoPtr_rendererSortingOrders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "rendererSortingOrders");
			Biped.NativeFieldInfoPtr_curShouldRotVel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "curShouldRotVel");
			Biped.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "anim");
			Biped.NativeFieldInfoPtr_grabber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "grabber");
			Biped.NativeFieldInfoPtr_defGrabberPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "defGrabberPos");
			Biped.NativeFieldInfoPtr_gun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "gun");
			Biped.NativeFieldInfoPtr_prevGunPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "prevGunPos");
			Biped.NativeFieldInfoPtr_prevGunRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "prevGunRot");
			Biped.NativeFieldInfoPtr_defLegWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "defLegWidth");
			Biped.NativeFieldInfoPtr_defUArmWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "defUArmWidth");
			Biped.NativeFieldInfoPtr_defLArmWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "defLArmWidth");
			Biped.NativeFieldInfoPtr_defULen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "defULen");
			Biped.NativeFieldInfoPtr_defLLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "defLLen");
			Biped.NativeFieldInfoPtr_defLegGirth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "defLegGirth");
			Biped.NativeFieldInfoPtr_defFootScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "defFootScale");
			Biped.NativeFieldInfoPtr_lHandTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "lHandTarget");
			Biped.NativeFieldInfoPtr_shouldSwag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "shouldSwag");
			Biped.NativeFieldInfoPtr_onScreenOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "onScreenOverride");
			Biped.NativeFieldInfoPtr_headLocPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "headLocPos");
			Biped.NativeFieldInfoPtr_gunTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Biped>.NativeClassPtr, "gunTrans");
			Biped.NativeMethodInfoPtr_InitShit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664640);
			Biped.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664641);
			Biped.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664642);
			Biped.NativeMethodInfoPtr_LateUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664643);
			Biped.NativeMethodInfoPtr_Teleport_Public_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664644);
			Biped.NativeMethodInfoPtr_DrawBack_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664645);
			Biped.NativeMethodInfoPtr_DragLegs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664646);
			Biped.NativeMethodInfoPtr_DragHip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664647);
			Biped.NativeMethodInfoPtr_Swagger_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664648);
			Biped.NativeMethodInfoPtr_SwagHalfShoulders_Public_Virtual_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664649);
			Biped.NativeMethodInfoPtr_SwagHead_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664650);
			Biped.NativeMethodInfoPtr_SetStance_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664651);
			Biped.NativeMethodInfoPtr_ZeroPaws_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664652);
			Biped.NativeMethodInfoPtr_SetPrevPos_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664653);
			Biped.NativeMethodInfoPtr_SetLatePrevPos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664654);
			Biped.NativeMethodInfoPtr_BloodSplashed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664655);
			Biped.NativeMethodInfoPtr_ResetMat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664656);
			Biped.NativeMethodInfoPtr_KilledPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664657);
			Biped.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Biped>.NativeClassPtr, 100664658);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00062838 File Offset: 0x00060A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47161, XrefRangeEnd = 47253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Biped.NativeMethodInfoPtr_InitShit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00062874 File Offset: 0x00060A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47253, XrefRangeEnd = 47338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Biped.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x000628A8 File Offset: 0x00060AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47338, XrefRangeEnd = 47381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Biped.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x000628E4 File Offset: 0x00060AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47381, XrefRangeEnd = 47437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Biped.NativeMethodInfoPtr_LateUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00062920 File Offset: 0x00060B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47437, XrefRangeEnd = 47439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Teleport(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Biped.NativeMethodInfoPtr_Teleport_Public_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0006296C File Offset: 0x00060B6C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DrawBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Biped.NativeMethodInfoPtr_DrawBack_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000629A8 File Offset: 0x00060BA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47507, RefRangeEnd = 47508, XrefRangeStart = 47439, XrefRangeEnd = 47507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DragLegs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Biped.NativeMethodInfoPtr_DragLegs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x000629DC File Offset: 0x00060BDC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DragHip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Biped.NativeMethodInfoPtr_DragHip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00062A10 File Offset: 0x00060C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47508, XrefRangeEnd = 47546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Swagger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Biped.NativeMethodInfoPtr_Swagger_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00062A4C File Offset: 0x00060C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47546, XrefRangeEnd = 47572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SwagHalfShoulders(int i, bool handBased)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handBased;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Biped.NativeMethodInfoPtr_SwagHalfShoulders_Public_Virtual_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00062AA4 File Offset: 0x00060CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47572, XrefRangeEnd = 47603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SwagHead(bool handBased)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handBased;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Biped.NativeMethodInfoPtr_SwagHead_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00062AF0 File Offset: 0x00060CF0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetStance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Biped.NativeMethodInfoPtr_SetStance_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00062B2C File Offset: 0x00060D2C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ZeroPaws()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Biped.NativeMethodInfoPtr_ZeroPaws_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00062B68 File Offset: 0x00060D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47603, XrefRangeEnd = 47613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetPrevPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Biped.NativeMethodInfoPtr_SetPrevPos_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00062BA4 File Offset: 0x00060DA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47618, RefRangeEnd = 47620, XrefRangeStart = 47613, XrefRangeEnd = 47618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLatePrevPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Biped.NativeMethodInfoPtr_SetLatePrevPos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00062BD8 File Offset: 0x00060DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 47662, RefRangeEnd = 47665, XrefRangeStart = 47620, XrefRangeEnd = 47662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BloodSplashed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Biped.NativeMethodInfoPtr_BloodSplashed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00062C0C File Offset: 0x00060E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47724, RefRangeEnd = 47725, XrefRangeStart = 47665, XrefRangeEnd = 47724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetMat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Biped.NativeMethodInfoPtr_ResetMat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00062C40 File Offset: 0x00060E40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 47784, RefRangeEnd = 47787, XrefRangeStart = 47725, XrefRangeEnd = 47784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KilledPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Biped.NativeMethodInfoPtr_KilledPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00062C74 File Offset: 0x00060E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Biped()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Biped>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Biped.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0000BB56 File Offset: 0x00009D56
		public Biped(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x00062CB0 File Offset: 0x00060EB0
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x0000BB5F File Offset: 0x00009D5F
		public unsafe GuardState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuardState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00062CE0 File Offset: 0x00060EE0
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x0000BB7E File Offset: 0x00009D7E
		public unsafe float maxHipDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_maxHipDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_maxHipDist)) = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00062D08 File Offset: 0x00060F08
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x0000BB99 File Offset: 0x00009D99
		public unsafe Vector2 rightVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_rightVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_rightVect)) = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00062D30 File Offset: 0x00060F30
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x0000BBB4 File Offset: 0x00009DB4
		public unsafe Vector2 backVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_backVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_backVect)) = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00062D58 File Offset: 0x00060F58
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x0000BBCF File Offset: 0x00009DCF
		public unsafe Il2CppStructArray<Vector2> trueFPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_trueFPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_trueFPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00062D88 File Offset: 0x00060F88
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x0000BBEE File Offset: 0x00009DEE
		public unsafe Vector2 trueHPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_trueHPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_trueHPos)) = value;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00062DB0 File Offset: 0x00060FB0
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x0000BC09 File Offset: 0x00009E09
		public unsafe Vector2 prevHipsPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_prevHipsPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_prevHipsPos)) = value;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00062DD8 File Offset: 0x00060FD8
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x0000BC24 File Offset: 0x00009E24
		public unsafe GameObject gapFiller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_gapFiller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_gapFiller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x00062E08 File Offset: 0x00061008
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x0000BC43 File Offset: 0x00009E43
		public unsafe Il2CppStructArray<Vector2> hipPts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_hipPts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_hipPts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00062E38 File Offset: 0x00061038
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x0000BC62 File Offset: 0x00009E62
		public unsafe Il2CppStructArray<Vector2> chestPts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_chestPts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_chestPts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00062E68 File Offset: 0x00061068
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x0000BC81 File Offset: 0x00009E81
		public unsafe List<int> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x00062E98 File Offset: 0x00061098
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		public unsafe Il2CppReferenceArray<Renderer> renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00062EC8 File Offset: 0x000610C8
		// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x0000BCBF File Offset: 0x00009EBF
		public unsafe Il2CppStructArray<int> rendererSortingOrders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_rendererSortingOrders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_rendererSortingOrders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x00062EF8 File Offset: 0x000610F8
		// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x0000BCDE File Offset: 0x00009EDE
		public unsafe Il2CppStructArray<float> curShouldRotVel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_curShouldRotVel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_curShouldRotVel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00062F28 File Offset: 0x00061128
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x0000BCFD File Offset: 0x00009EFD
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00062F58 File Offset: 0x00061158
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x0000BD1C File Offset: 0x00009F1C
		public unsafe Grabber grabber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_grabber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grabber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_grabber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00062F88 File Offset: 0x00061188
		// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x0000BD3B File Offset: 0x00009F3B
		public unsafe Il2CppStructArray<Vector2> defGrabberPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defGrabberPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defGrabberPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00062FB8 File Offset: 0x000611B8
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x0000BD5A File Offset: 0x00009F5A
		public unsafe Transform gun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_gun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_gun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00062FE8 File Offset: 0x000611E8
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x0000BD79 File Offset: 0x00009F79
		public unsafe Vector2 prevGunPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_prevGunPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_prevGunPos)) = value;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00063010 File Offset: 0x00061210
		// (set) Token: 0x06000FFE RID: 4094 RVA: 0x0000BD94 File Offset: 0x00009F94
		public unsafe float prevGunRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_prevGunRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_prevGunRot)) = value;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x00063038 File Offset: 0x00061238
		// (set) Token: 0x06001000 RID: 4096 RVA: 0x0000BDAF File Offset: 0x00009FAF
		public unsafe float defLegWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defLegWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defLegWidth)) = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x00063060 File Offset: 0x00061260
		// (set) Token: 0x06001002 RID: 4098 RVA: 0x0000BDCA File Offset: 0x00009FCA
		public unsafe float defUArmWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defUArmWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defUArmWidth)) = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00063088 File Offset: 0x00061288
		// (set) Token: 0x06001004 RID: 4100 RVA: 0x0000BDE5 File Offset: 0x00009FE5
		public unsafe float defLArmWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defLArmWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defLArmWidth)) = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x000630B0 File Offset: 0x000612B0
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x0000BE00 File Offset: 0x0000A000
		public unsafe float defULen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defULen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defULen)) = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x000630D8 File Offset: 0x000612D8
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x0000BE1B File Offset: 0x0000A01B
		public unsafe float defLLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defLLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defLLen)) = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x00063100 File Offset: 0x00061300
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x0000BE36 File Offset: 0x0000A036
		public unsafe float defLegGirth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defLegGirth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defLegGirth)) = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00063128 File Offset: 0x00061328
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x0000BE51 File Offset: 0x0000A051
		public unsafe Il2CppStructArray<Vector2> defFootScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defFootScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_defFootScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x00063158 File Offset: 0x00061358
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x0000BE70 File Offset: 0x0000A070
		public unsafe Transform lHandTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_lHandTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_lHandTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x00063188 File Offset: 0x00061388
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x0000BE8F File Offset: 0x0000A08F
		public unsafe Vector2 shouldSwag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_shouldSwag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_shouldSwag)) = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x000631B0 File Offset: 0x000613B0
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x0000BEAA File Offset: 0x0000A0AA
		public unsafe bool onScreenOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_onScreenOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_onScreenOverride)) = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x000631D8 File Offset: 0x000613D8
		// (set) Token: 0x06001014 RID: 4116 RVA: 0x0000BEC5 File Offset: 0x0000A0C5
		public unsafe Vector3 headLocPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_headLocPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_headLocPos)) = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x00063200 File Offset: 0x00061400
		// (set) Token: 0x06001016 RID: 4118 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		public unsafe Transform gunTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_gunTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Biped.NativeFieldInfoPtr_gunTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeFieldInfoPtr_maxHipDist;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeFieldInfoPtr_rightVect;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeFieldInfoPtr_backVect;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeFieldInfoPtr_trueFPos;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeFieldInfoPtr_trueHPos;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeFieldInfoPtr_prevHipsPos;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeFieldInfoPtr_gapFiller;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeFieldInfoPtr_hipPts;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeFieldInfoPtr_chestPts;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeFieldInfoPtr_renderers;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeFieldInfoPtr_rendererSortingOrders;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeFieldInfoPtr_curShouldRotVel;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeFieldInfoPtr_grabber;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeFieldInfoPtr_defGrabberPos;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeFieldInfoPtr_gun;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeFieldInfoPtr_prevGunPos;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeFieldInfoPtr_prevGunRot;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeFieldInfoPtr_defLegWidth;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeFieldInfoPtr_defUArmWidth;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeFieldInfoPtr_defLArmWidth;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeFieldInfoPtr_defULen;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeFieldInfoPtr_defLLen;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeFieldInfoPtr_defLegGirth;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeFieldInfoPtr_defFootScale;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeFieldInfoPtr_lHandTarget;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeFieldInfoPtr_shouldSwag;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeFieldInfoPtr_onScreenOverride;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeFieldInfoPtr_headLocPos;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeFieldInfoPtr_gunTrans;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_InitShit_Public_Virtual_Void_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_Void_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_Teleport_Public_Virtual_Void_Vector3_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_DrawBack_Public_Virtual_Void_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_DragLegs_Public_Void_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_DragHip_Public_Void_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_Swagger_Public_Virtual_Void_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_SwagHalfShoulders_Public_Virtual_Void_Int32_Boolean_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_SwagHead_Public_Virtual_Void_Boolean_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_SetStance_Public_Virtual_Void_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_ZeroPaws_Public_Virtual_Void_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_SetPrevPos_Public_Virtual_Void_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_SetLatePrevPos_Public_Void_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_BloodSplashed_Public_Void_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_ResetMat_Public_Void_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_KilledPlayer_Public_Void_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
