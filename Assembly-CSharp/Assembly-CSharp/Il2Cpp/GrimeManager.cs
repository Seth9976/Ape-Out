using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000EB RID: 235
	public class GrimeManager : MonoBehaviour
	{
		// Token: 0x06001BE5 RID: 7141 RVA: 0x00082D50 File Offset: 0x00080F50
		// Note: this type is marked as 'beforefieldinit'.
		static GrimeManager()
		{
			Il2CppClassPointerStore<GrimeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GrimeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr);
			GrimeManager.NativeFieldInfoPtr_matArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "matArr");
			GrimeManager.NativeFieldInfoPtr_camLockedMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "camLockedMats");
			GrimeManager.NativeFieldInfoPtr_noCamMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "noCamMats");
			GrimeManager.NativeFieldInfoPtr_paralaxMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "paralaxMats");
			GrimeManager.NativeFieldInfoPtr_mainCamQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "mainCamQuad");
			GrimeManager.NativeFieldInfoPtr_halftoneTexs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "halftoneTexs");
			GrimeManager.NativeFieldInfoPtr_fontMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "fontMats");
			GrimeManager.NativeFieldInfoPtr_wallTexs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "wallTexs");
			GrimeManager.NativeFieldInfoPtr_wallMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "wallMats");
			GrimeManager.NativeFieldInfoPtr_floorTexs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "floorTexs");
			GrimeManager.NativeFieldInfoPtr_floorMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "floorMats");
			GrimeManager.NativeFieldInfoPtr_blip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "blip");
			GrimeManager.NativeFieldInfoPtr_offSet1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "offSet1");
			GrimeManager.NativeFieldInfoPtr_offSet2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "offSet2");
			GrimeManager.NativeFieldInfoPtr_camPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "camPos");
			GrimeManager.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "cam");
			GrimeManager.NativeFieldInfoPtr_nOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "nOffset");
			GrimeManager.NativeFieldInfoPtr_shaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "shaders");
			GrimeManager.NativeFieldInfoPtr_offSetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "offSetID");
			GrimeManager.NativeFieldInfoPtr_tim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "tim");
			GrimeManager.NativeFieldInfoPtr_doFirstBlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "doFirstBlip");
			GrimeManager.NativeFieldInfoPtr_doSecondBlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "doSecondBlip");
			GrimeManager.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, 100665572);
			GrimeManager.NativeMethodInfoPtr_Bullshit_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, 100665573);
			GrimeManager.NativeMethodInfoPtr_ManageGrime_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, 100665574);
			GrimeManager.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, 100665575);
			GrimeManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, 100665576);
			GrimeManager.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, 100665577);
			GrimeManager.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, 100665578);
			GrimeManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, 100665579);
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x00082FD8 File Offset: 0x000811D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62579, XrefRangeEnd = 62607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0008300C File Offset: 0x0008120C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62607, XrefRangeEnd = 62610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Bullshit(float blamo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref blamo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager.NativeMethodInfoPtr_Bullshit_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00083058 File Offset: 0x00081258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62610, XrefRangeEnd = 62613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ManageGrime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager.NativeMethodInfoPtr_ManageGrime_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00083098 File Offset: 0x00081298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62613, XrefRangeEnd = 62615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x000830CC File Offset: 0x000812CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62615, XrefRangeEnd = 62625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00083100 File Offset: 0x00081300
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00083134 File Offset: 0x00081334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62625, XrefRangeEnd = 62635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00083168 File Offset: 0x00081368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62635, XrefRangeEnd = 62642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrimeManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00013AC9 File Offset: 0x00011CC9
		public GrimeManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x000831A4 File Offset: 0x000813A4
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x00013AD2 File Offset: 0x00011CD2
		public unsafe Il2CppReferenceArray<Material> matArr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_matArr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_matArr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x000831D4 File Offset: 0x000813D4
		// (set) Token: 0x06001BF2 RID: 7154 RVA: 0x00013AF1 File Offset: 0x00011CF1
		public unsafe Il2CppReferenceArray<Material> camLockedMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_camLockedMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_camLockedMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00083204 File Offset: 0x00081404
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x00013B10 File Offset: 0x00011D10
		public unsafe Il2CppReferenceArray<Material> noCamMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_noCamMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_noCamMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x00083234 File Offset: 0x00081434
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x00013B2F File Offset: 0x00011D2F
		public unsafe Il2CppReferenceArray<Material> paralaxMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_paralaxMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_paralaxMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x00083264 File Offset: 0x00081464
		// (set) Token: 0x06001BF8 RID: 7160 RVA: 0x00013B4E File Offset: 0x00011D4E
		public unsafe Material mainCamQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_mainCamQuad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_mainCamQuad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x00083294 File Offset: 0x00081494
		// (set) Token: 0x06001BFA RID: 7162 RVA: 0x00013B6D File Offset: 0x00011D6D
		public unsafe Il2CppReferenceArray<Texture> halftoneTexs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_halftoneTexs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_halftoneTexs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x000832C4 File Offset: 0x000814C4
		// (set) Token: 0x06001BFC RID: 7164 RVA: 0x00013B8C File Offset: 0x00011D8C
		public unsafe Il2CppReferenceArray<Material> fontMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_fontMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_fontMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x000832F4 File Offset: 0x000814F4
		// (set) Token: 0x06001BFE RID: 7166 RVA: 0x00013BAB File Offset: 0x00011DAB
		public unsafe Il2CppReferenceArray<Texture> wallTexs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_wallTexs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_wallTexs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x00083324 File Offset: 0x00081524
		// (set) Token: 0x06001C00 RID: 7168 RVA: 0x00013BCA File Offset: 0x00011DCA
		public unsafe Il2CppReferenceArray<Material> wallMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_wallMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_wallMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x00083354 File Offset: 0x00081554
		// (set) Token: 0x06001C02 RID: 7170 RVA: 0x00013BE9 File Offset: 0x00011DE9
		public unsafe Il2CppReferenceArray<Texture> floorTexs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_floorTexs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_floorTexs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x00083384 File Offset: 0x00081584
		// (set) Token: 0x06001C04 RID: 7172 RVA: 0x00013C08 File Offset: 0x00011E08
		public unsafe Il2CppReferenceArray<Material> floorMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_floorMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_floorMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x000833B4 File Offset: 0x000815B4
		// (set) Token: 0x06001C06 RID: 7174 RVA: 0x00013C27 File Offset: 0x00011E27
		public unsafe int blip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_blip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_blip)) = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x000833DC File Offset: 0x000815DC
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x00013C42 File Offset: 0x00011E42
		public unsafe Vector4 offSet1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_offSet1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_offSet1)) = value;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x00083404 File Offset: 0x00081604
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x00013C5D File Offset: 0x00011E5D
		public unsafe Vector4 offSet2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_offSet2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_offSet2)) = value;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x0008342C File Offset: 0x0008162C
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x00013C78 File Offset: 0x00011E78
		public unsafe Vector2 camPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_camPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_camPos)) = value;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x00083454 File Offset: 0x00081654
		// (set) Token: 0x06001C0E RID: 7182 RVA: 0x00013C93 File Offset: 0x00011E93
		public unsafe Transform cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x00083484 File Offset: 0x00081684
		// (set) Token: 0x06001C10 RID: 7184 RVA: 0x00013CB2 File Offset: 0x00011EB2
		public unsafe Vector4 nOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_nOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_nOffset)) = value;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x000834AC File Offset: 0x000816AC
		// (set) Token: 0x06001C12 RID: 7186 RVA: 0x00013CCD File Offset: 0x00011ECD
		public unsafe Il2CppReferenceArray<Shader> shaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_shaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Shader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_shaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x000834DC File Offset: 0x000816DC
		// (set) Token: 0x06001C14 RID: 7188 RVA: 0x00013CEC File Offset: 0x00011EEC
		public unsafe int offSetID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_offSetID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_offSetID)) = value;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x00083504 File Offset: 0x00081704
		// (set) Token: 0x06001C16 RID: 7190 RVA: 0x00013D07 File Offset: 0x00011F07
		public unsafe float tim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_tim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_tim)) = value;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x0008352C File Offset: 0x0008172C
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x00013D22 File Offset: 0x00011F22
		public unsafe bool doFirstBlip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_doFirstBlip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_doFirstBlip)) = value;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x00083554 File Offset: 0x00081754
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x00013D3D File Offset: 0x00011F3D
		public unsafe bool doSecondBlip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_doSecondBlip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager.NativeFieldInfoPtr_doSecondBlip)) = value;
			}
		}

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeFieldInfoPtr_matArr;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeFieldInfoPtr_camLockedMats;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeFieldInfoPtr_noCamMats;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeFieldInfoPtr_paralaxMats;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeFieldInfoPtr_mainCamQuad;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeFieldInfoPtr_halftoneTexs;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeFieldInfoPtr_fontMats;

		// Token: 0x040010A2 RID: 4258
		private static readonly IntPtr NativeFieldInfoPtr_wallTexs;

		// Token: 0x040010A3 RID: 4259
		private static readonly IntPtr NativeFieldInfoPtr_wallMats;

		// Token: 0x040010A4 RID: 4260
		private static readonly IntPtr NativeFieldInfoPtr_floorTexs;

		// Token: 0x040010A5 RID: 4261
		private static readonly IntPtr NativeFieldInfoPtr_floorMats;

		// Token: 0x040010A6 RID: 4262
		private static readonly IntPtr NativeFieldInfoPtr_blip;

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeFieldInfoPtr_offSet1;

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeFieldInfoPtr_offSet2;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeFieldInfoPtr_camPos;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeFieldInfoPtr_nOffset;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeFieldInfoPtr_shaders;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeFieldInfoPtr_offSetID;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeFieldInfoPtr_tim;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeFieldInfoPtr_doFirstBlip;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeFieldInfoPtr_doSecondBlip;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_Bullshit_Private_IEnumerator_Single_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_ManageGrime_Private_IEnumerator_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000306 RID: 774
		[ObfuscatedName("GrimeManager+<Bullshit>d__21")]
		public sealed class _Bullshit_d__21 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F7C RID: 20348 RVA: 0x00122C30 File Offset: 0x00120E30
			// Note: this type is marked as 'beforefieldinit'.
			static _Bullshit_d__21()
			{
				Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "<Bullshit>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr);
				GrimeManager._Bullshit_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr, "<>1__state");
				GrimeManager._Bullshit_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr, "<>2__current");
				GrimeManager._Bullshit_d__21.NativeFieldInfoPtr_blamo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr, "blamo");
				GrimeManager._Bullshit_d__21.NativeFieldInfoPtr__tim_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr, "<tim>5__2");
				GrimeManager._Bullshit_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr, 100665580);
				GrimeManager._Bullshit_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr, 100665581);
				GrimeManager._Bullshit_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr, 100665582);
				GrimeManager._Bullshit_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr, 100665583);
				GrimeManager._Bullshit_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr, 100665584);
				GrimeManager._Bullshit_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr, 100665585);
			}

			// Token: 0x06004F7D RID: 20349 RVA: 0x00122D24 File Offset: 0x00120F24
			[CallerCount(0)]
			public unsafe _Bullshit_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrimeManager._Bullshit_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager._Bullshit_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F7E RID: 20350 RVA: 0x00122D6C File Offset: 0x00120F6C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager._Bullshit_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F7F RID: 20351 RVA: 0x00122DA0 File Offset: 0x00120FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62562, XrefRangeEnd = 62565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager._Bullshit_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CFC RID: 7420
			// (get) Token: 0x06004F80 RID: 20352 RVA: 0x00122DDC File Offset: 0x00120FDC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager._Bullshit_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F81 RID: 20353 RVA: 0x00122E1C File Offset: 0x0012101C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62565, XrefRangeEnd = 62570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager._Bullshit_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CFD RID: 7421
			// (get) Token: 0x06004F82 RID: 20354 RVA: 0x00122E50 File Offset: 0x00121050
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager._Bullshit_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F83 RID: 20355 RVA: 0x0002E7E8 File Offset: 0x0002C9E8
			public _Bullshit_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CF8 RID: 7416
			// (get) Token: 0x06004F84 RID: 20356 RVA: 0x00122E90 File Offset: 0x00121090
			// (set) Token: 0x06004F85 RID: 20357 RVA: 0x0002E7F1 File Offset: 0x0002C9F1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._Bullshit_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._Bullshit_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CF9 RID: 7417
			// (get) Token: 0x06004F86 RID: 20358 RVA: 0x00122EB8 File Offset: 0x001210B8
			// (set) Token: 0x06004F87 RID: 20359 RVA: 0x0002E80C File Offset: 0x0002CA0C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._Bullshit_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._Bullshit_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CFA RID: 7418
			// (get) Token: 0x06004F88 RID: 20360 RVA: 0x00122EE8 File Offset: 0x001210E8
			// (set) Token: 0x06004F89 RID: 20361 RVA: 0x0002E82B File Offset: 0x0002CA2B
			public unsafe float blamo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._Bullshit_d__21.NativeFieldInfoPtr_blamo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._Bullshit_d__21.NativeFieldInfoPtr_blamo)) = value;
				}
			}

			// Token: 0x17001CFB RID: 7419
			// (get) Token: 0x06004F8A RID: 20362 RVA: 0x00122F10 File Offset: 0x00121110
			// (set) Token: 0x06004F8B RID: 20363 RVA: 0x0002E846 File Offset: 0x0002CA46
			public unsafe float _tim_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._Bullshit_d__21.NativeFieldInfoPtr__tim_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._Bullshit_d__21.NativeFieldInfoPtr__tim_5__2)) = value;
				}
			}

			// Token: 0x04003438 RID: 13368
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003439 RID: 13369
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400343A RID: 13370
			private static readonly IntPtr NativeFieldInfoPtr_blamo;

			// Token: 0x0400343B RID: 13371
			private static readonly IntPtr NativeFieldInfoPtr__tim_5__2;

			// Token: 0x0400343C RID: 13372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400343D RID: 13373
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400343E RID: 13374
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400343F RID: 13375
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003440 RID: 13376
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003441 RID: 13377
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000307 RID: 775
		[ObfuscatedName("GrimeManager+<ManageGrime>d__22")]
		public sealed class _ManageGrime_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F8C RID: 20364 RVA: 0x00122F38 File Offset: 0x00121138
			// Note: this type is marked as 'beforefieldinit'.
			static _ManageGrime_d__22()
			{
				Il2CppClassPointerStore<GrimeManager._ManageGrime_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrimeManager>.NativeClassPtr, "<ManageGrime>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrimeManager._ManageGrime_d__22>.NativeClassPtr);
				GrimeManager._ManageGrime_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager._ManageGrime_d__22>.NativeClassPtr, "<>1__state");
				GrimeManager._ManageGrime_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager._ManageGrime_d__22>.NativeClassPtr, "<>2__current");
				GrimeManager._ManageGrime_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrimeManager._ManageGrime_d__22>.NativeClassPtr, "<>4__this");
				GrimeManager._ManageGrime_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager._ManageGrime_d__22>.NativeClassPtr, 100665586);
				GrimeManager._ManageGrime_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager._ManageGrime_d__22>.NativeClassPtr, 100665587);
				GrimeManager._ManageGrime_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager._ManageGrime_d__22>.NativeClassPtr, 100665588);
				GrimeManager._ManageGrime_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager._ManageGrime_d__22>.NativeClassPtr, 100665589);
				GrimeManager._ManageGrime_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager._ManageGrime_d__22>.NativeClassPtr, 100665590);
				GrimeManager._ManageGrime_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrimeManager._ManageGrime_d__22>.NativeClassPtr, 100665591);
			}

			// Token: 0x06004F8D RID: 20365 RVA: 0x00123018 File Offset: 0x00121218
			[CallerCount(0)]
			public unsafe _ManageGrime_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrimeManager._ManageGrime_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager._ManageGrime_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F8E RID: 20366 RVA: 0x00123060 File Offset: 0x00121260
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager._ManageGrime_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F8F RID: 20367 RVA: 0x00123094 File Offset: 0x00121294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62570, XrefRangeEnd = 62574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager._ManageGrime_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D01 RID: 7425
			// (get) Token: 0x06004F90 RID: 20368 RVA: 0x001230D0 File Offset: 0x001212D0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager._ManageGrime_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F91 RID: 20369 RVA: 0x00123110 File Offset: 0x00121310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62574, XrefRangeEnd = 62579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager._ManageGrime_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D02 RID: 7426
			// (get) Token: 0x06004F92 RID: 20370 RVA: 0x00123144 File Offset: 0x00121344
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrimeManager._ManageGrime_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F93 RID: 20371 RVA: 0x0002E861 File Offset: 0x0002CA61
			public _ManageGrime_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CFE RID: 7422
			// (get) Token: 0x06004F94 RID: 20372 RVA: 0x00123184 File Offset: 0x00121384
			// (set) Token: 0x06004F95 RID: 20373 RVA: 0x0002E86A File Offset: 0x0002CA6A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._ManageGrime_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._ManageGrime_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CFF RID: 7423
			// (get) Token: 0x06004F96 RID: 20374 RVA: 0x001231AC File Offset: 0x001213AC
			// (set) Token: 0x06004F97 RID: 20375 RVA: 0x0002E885 File Offset: 0x0002CA85
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._ManageGrime_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._ManageGrime_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D00 RID: 7424
			// (get) Token: 0x06004F98 RID: 20376 RVA: 0x001231DC File Offset: 0x001213DC
			// (set) Token: 0x06004F99 RID: 20377 RVA: 0x0002E8A4 File Offset: 0x0002CAA4
			public unsafe GrimeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._ManageGrime_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrimeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrimeManager._ManageGrime_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003442 RID: 13378
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003443 RID: 13379
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003444 RID: 13380
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003445 RID: 13381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003446 RID: 13382
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003447 RID: 13383
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003448 RID: 13384
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003449 RID: 13385
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400344A RID: 13386
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
