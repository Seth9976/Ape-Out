using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200014B RID: 331
	public class PalleteMapper : MonoBehaviour
	{
		// Token: 0x060027A2 RID: 10146 RVA: 0x000A22DC File Offset: 0x000A04DC
		// Note: this type is marked as 'beforefieldinit'.
		static PalleteMapper()
		{
			Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PalleteMapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr);
			PalleteMapper.NativeFieldInfoPtr_blueTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "blueTex");
			PalleteMapper.NativeFieldInfoPtr_blueSecondaryTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "blueSecondaryTex");
			PalleteMapper.NativeFieldInfoPtr_greenTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "greenTex");
			PalleteMapper.NativeFieldInfoPtr_alarmTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "alarmTex");
			PalleteMapper.NativeFieldInfoPtr_alarmSecondaryTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "alarmSecondaryTex");
			PalleteMapper.NativeFieldInfoPtr_lightsOutTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "lightsOutTex");
			PalleteMapper.NativeFieldInfoPtr_bwTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "bwTex");
			PalleteMapper.NativeFieldInfoPtr_cityTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "cityTex");
			PalleteMapper.NativeFieldInfoPtr_buildingTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "buildingTex");
			PalleteMapper.NativeFieldInfoPtr_bunkerTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "bunkerTex");
			PalleteMapper.NativeFieldInfoPtr_bunkerSecondaryTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "bunkerSecondaryTex");
			PalleteMapper.NativeFieldInfoPtr_flameTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "flameTex");
			PalleteMapper.NativeFieldInfoPtr_flameSecondaryTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "flameSecondaryTex");
			PalleteMapper.NativeFieldInfoPtr_stealthTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "stealthTex");
			PalleteMapper.NativeFieldInfoPtr_stealthBoatTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "stealthBoatTex");
			PalleteMapper.NativeFieldInfoPtr_stealthSecondaryTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "stealthSecondaryTex");
			PalleteMapper.NativeFieldInfoPtr_outdoorTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "outdoorTex");
			PalleteMapper.NativeFieldInfoPtr_boatTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "boatTex");
			PalleteMapper.NativeFieldInfoPtr_boatDarkTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "boatDarkTex");
			PalleteMapper.NativeFieldInfoPtr_mainRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "mainRenderer");
			PalleteMapper.NativeFieldInfoPtr_crazyTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "crazyTex");
			PalleteMapper.NativeFieldInfoPtr_pauseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "pauseTex");
			PalleteMapper.NativeFieldInfoPtr_floorMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "floorMat");
			PalleteMapper.NativeFieldInfoPtr_shadowMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "shadowMat");
			PalleteMapper.NativeFieldInfoPtr_guardMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "guardMat");
			PalleteMapper.NativeFieldInfoPtr_smokeMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "smokeMat");
			PalleteMapper.NativeFieldInfoPtr_doorMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "doorMat");
			PalleteMapper.NativeFieldInfoPtr_glassMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "glassMat");
			PalleteMapper.NativeFieldInfoPtr_glassPartMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "glassPartMat");
			PalleteMapper.NativeFieldInfoPtr_cageMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "cageMat");
			PalleteMapper.NativeFieldInfoPtr_apeMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "apeMat");
			PalleteMapper.NativeFieldInfoPtr_apeBloodMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "apeBloodMat");
			PalleteMapper.NativeFieldInfoPtr_fireExtinguisherMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "fireExtinguisherMat");
			PalleteMapper.NativeFieldInfoPtr_tableMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "tableMat");
			PalleteMapper.NativeFieldInfoPtr_bloodMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "bloodMat");
			PalleteMapper.NativeFieldInfoPtr_flashMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "flashMat");
			PalleteMapper.NativeFieldInfoPtr_vestMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "vestMat");
			PalleteMapper.NativeFieldInfoPtr_gunMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "gunMat");
			PalleteMapper.NativeFieldInfoPtr_fireBackpackMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "fireBackpackMat");
			PalleteMapper.NativeFieldInfoPtr_shadowGrimeMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "shadowGrimeMat");
			PalleteMapper.NativeFieldInfoPtr_halftoneMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "halftoneMat");
			PalleteMapper.NativeFieldInfoPtr_woodMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "woodMat");
			PalleteMapper.NativeFieldInfoPtr_treeMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "treeMat");
			PalleteMapper.NativeFieldInfoPtr_rockMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "rockMat");
			PalleteMapper.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "me");
			PalleteMapper.NativeFieldInfoPtr_prePauseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, "prePauseTex");
			PalleteMapper.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, 100666475);
			PalleteMapper.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, 100666476);
			PalleteMapper.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, 100666477);
			PalleteMapper.NativeMethodInfoPtr_UnPause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, 100666478);
			PalleteMapper.NativeMethodInfoPtr_ChangePallete_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, 100666479);
			PalleteMapper.NativeMethodInfoPtr_SetTextures_Public_Void_Texture_Texture_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, 100666480);
			PalleteMapper.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, 100666481);
			PalleteMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr, 100666482);
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x000A2744 File Offset: 0x000A0944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75602, XrefRangeEnd = 75604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteMapper.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x000A2778 File Offset: 0x000A0978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75604, XrefRangeEnd = 75613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteMapper.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000A27AC File Offset: 0x000A09AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75665, RefRangeEnd = 75666, XrefRangeStart = 75613, XrefRangeEnd = 75665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteMapper.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x000A27E0 File Offset: 0x000A09E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75694, RefRangeEnd = 75695, XrefRangeStart = 75666, XrefRangeEnd = 75694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteMapper.NativeMethodInfoPtr_UnPause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x000A2814 File Offset: 0x000A0A14
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 75868, RefRangeEnd = 75886, XrefRangeStart = 75695, XrefRangeEnd = 75868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePallete(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteMapper.NativeMethodInfoPtr_ChangePallete_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x000A2858 File Offset: 0x000A0A58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 75908, RefRangeEnd = 75911, XrefRangeStart = 75886, XrefRangeEnd = 75908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTextures(Texture a, Texture b, Texture c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteMapper.NativeMethodInfoPtr_SetTextures_Public_Void_Texture_Texture_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000A28C0 File Offset: 0x000A0AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75918, RefRangeEnd = 75919, XrefRangeStart = 75911, XrefRangeEnd = 75918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(int i, Texture a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteMapper.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x000A2910 File Offset: 0x000A0B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75919, XrefRangeEnd = 75925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PalleteMapper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PalleteMapper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x0001B8F7 File Offset: 0x00019AF7
		public PalleteMapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x060027AC RID: 10156 RVA: 0x000A294C File Offset: 0x000A0B4C
		// (set) Token: 0x060027AD RID: 10157 RVA: 0x0001B900 File Offset: 0x00019B00
		public unsafe Texture blueTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_blueTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_blueTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x000A297C File Offset: 0x000A0B7C
		// (set) Token: 0x060027AF RID: 10159 RVA: 0x0001B91F File Offset: 0x00019B1F
		public unsafe Texture blueSecondaryTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_blueSecondaryTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_blueSecondaryTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x000A29AC File Offset: 0x000A0BAC
		// (set) Token: 0x060027B1 RID: 10161 RVA: 0x0001B93E File Offset: 0x00019B3E
		public unsafe Texture greenTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_greenTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_greenTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x000A29DC File Offset: 0x000A0BDC
		// (set) Token: 0x060027B3 RID: 10163 RVA: 0x0001B95D File Offset: 0x00019B5D
		public unsafe Texture alarmTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_alarmTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_alarmTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x000A2A0C File Offset: 0x000A0C0C
		// (set) Token: 0x060027B5 RID: 10165 RVA: 0x0001B97C File Offset: 0x00019B7C
		public unsafe Texture alarmSecondaryTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_alarmSecondaryTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_alarmSecondaryTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x000A2A3C File Offset: 0x000A0C3C
		// (set) Token: 0x060027B7 RID: 10167 RVA: 0x0001B99B File Offset: 0x00019B9B
		public unsafe Texture lightsOutTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_lightsOutTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_lightsOutTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x000A2A6C File Offset: 0x000A0C6C
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x0001B9BA File Offset: 0x00019BBA
		public unsafe Texture bwTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_bwTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_bwTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x000A2A9C File Offset: 0x000A0C9C
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x0001B9D9 File Offset: 0x00019BD9
		public unsafe Texture cityTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_cityTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_cityTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x000A2ACC File Offset: 0x000A0CCC
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x0001B9F8 File Offset: 0x00019BF8
		public unsafe Texture buildingTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_buildingTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_buildingTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x000A2AFC File Offset: 0x000A0CFC
		// (set) Token: 0x060027BF RID: 10175 RVA: 0x0001BA17 File Offset: 0x00019C17
		public unsafe Texture bunkerTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_bunkerTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_bunkerTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x000A2B2C File Offset: 0x000A0D2C
		// (set) Token: 0x060027C1 RID: 10177 RVA: 0x0001BA36 File Offset: 0x00019C36
		public unsafe Texture bunkerSecondaryTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_bunkerSecondaryTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_bunkerSecondaryTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x000A2B5C File Offset: 0x000A0D5C
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x0001BA55 File Offset: 0x00019C55
		public unsafe Texture flameTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_flameTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_flameTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x000A2B8C File Offset: 0x000A0D8C
		// (set) Token: 0x060027C5 RID: 10181 RVA: 0x0001BA74 File Offset: 0x00019C74
		public unsafe Texture flameSecondaryTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_flameSecondaryTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_flameSecondaryTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x000A2BBC File Offset: 0x000A0DBC
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x0001BA93 File Offset: 0x00019C93
		public unsafe Texture stealthTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_stealthTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_stealthTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x000A2BEC File Offset: 0x000A0DEC
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x0001BAB2 File Offset: 0x00019CB2
		public unsafe Texture stealthBoatTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_stealthBoatTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_stealthBoatTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x000A2C1C File Offset: 0x000A0E1C
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x0001BAD1 File Offset: 0x00019CD1
		public unsafe Texture stealthSecondaryTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_stealthSecondaryTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_stealthSecondaryTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x000A2C4C File Offset: 0x000A0E4C
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x0001BAF0 File Offset: 0x00019CF0
		public unsafe Texture outdoorTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_outdoorTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_outdoorTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x000A2C7C File Offset: 0x000A0E7C
		// (set) Token: 0x060027CF RID: 10191 RVA: 0x0001BB0F File Offset: 0x00019D0F
		public unsafe Texture boatTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_boatTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_boatTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x000A2CAC File Offset: 0x000A0EAC
		// (set) Token: 0x060027D1 RID: 10193 RVA: 0x0001BB2E File Offset: 0x00019D2E
		public unsafe Texture boatDarkTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_boatDarkTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_boatDarkTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x000A2CDC File Offset: 0x000A0EDC
		// (set) Token: 0x060027D3 RID: 10195 RVA: 0x0001BB4D File Offset: 0x00019D4D
		public unsafe Renderer mainRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_mainRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_mainRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x000A2D0C File Offset: 0x000A0F0C
		// (set) Token: 0x060027D5 RID: 10197 RVA: 0x0001BB6C File Offset: 0x00019D6C
		public unsafe Texture crazyTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_crazyTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_crazyTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x000A2D3C File Offset: 0x000A0F3C
		// (set) Token: 0x060027D7 RID: 10199 RVA: 0x0001BB8B File Offset: 0x00019D8B
		public unsafe Texture pauseTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_pauseTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_pauseTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x000A2D6C File Offset: 0x000A0F6C
		// (set) Token: 0x060027D9 RID: 10201 RVA: 0x0001BBAA File Offset: 0x00019DAA
		public unsafe Material floorMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_floorMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_floorMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x000A2D9C File Offset: 0x000A0F9C
		// (set) Token: 0x060027DB RID: 10203 RVA: 0x0001BBC9 File Offset: 0x00019DC9
		public unsafe Material shadowMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_shadowMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_shadowMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x000A2DCC File Offset: 0x000A0FCC
		// (set) Token: 0x060027DD RID: 10205 RVA: 0x0001BBE8 File Offset: 0x00019DE8
		public unsafe Il2CppReferenceArray<Material> guardMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_guardMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_guardMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x000A2DFC File Offset: 0x000A0FFC
		// (set) Token: 0x060027DF RID: 10207 RVA: 0x0001BC07 File Offset: 0x00019E07
		public unsafe Material smokeMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_smokeMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_smokeMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x000A2E2C File Offset: 0x000A102C
		// (set) Token: 0x060027E1 RID: 10209 RVA: 0x0001BC26 File Offset: 0x00019E26
		public unsafe Material doorMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_doorMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_doorMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x000A2E5C File Offset: 0x000A105C
		// (set) Token: 0x060027E3 RID: 10211 RVA: 0x0001BC45 File Offset: 0x00019E45
		public unsafe Material glassMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_glassMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_glassMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x000A2E8C File Offset: 0x000A108C
		// (set) Token: 0x060027E5 RID: 10213 RVA: 0x0001BC64 File Offset: 0x00019E64
		public unsafe Material glassPartMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_glassPartMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_glassPartMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x000A2EBC File Offset: 0x000A10BC
		// (set) Token: 0x060027E7 RID: 10215 RVA: 0x0001BC83 File Offset: 0x00019E83
		public unsafe Material cageMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_cageMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_cageMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x000A2EEC File Offset: 0x000A10EC
		// (set) Token: 0x060027E9 RID: 10217 RVA: 0x0001BCA2 File Offset: 0x00019EA2
		public unsafe Il2CppReferenceArray<Material> apeMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_apeMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_apeMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x000A2F1C File Offset: 0x000A111C
		// (set) Token: 0x060027EB RID: 10219 RVA: 0x0001BCC1 File Offset: 0x00019EC1
		public unsafe Material apeBloodMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_apeBloodMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_apeBloodMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x000A2F4C File Offset: 0x000A114C
		// (set) Token: 0x060027ED RID: 10221 RVA: 0x0001BCE0 File Offset: 0x00019EE0
		public unsafe Material fireExtinguisherMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_fireExtinguisherMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_fireExtinguisherMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x000A2F7C File Offset: 0x000A117C
		// (set) Token: 0x060027EF RID: 10223 RVA: 0x0001BCFF File Offset: 0x00019EFF
		public unsafe Material tableMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_tableMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_tableMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x000A2FAC File Offset: 0x000A11AC
		// (set) Token: 0x060027F1 RID: 10225 RVA: 0x0001BD1E File Offset: 0x00019F1E
		public unsafe Il2CppReferenceArray<Material> bloodMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_bloodMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_bloodMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x000A2FDC File Offset: 0x000A11DC
		// (set) Token: 0x060027F3 RID: 10227 RVA: 0x0001BD3D File Offset: 0x00019F3D
		public unsafe Material flashMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_flashMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_flashMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x000A300C File Offset: 0x000A120C
		// (set) Token: 0x060027F5 RID: 10229 RVA: 0x0001BD5C File Offset: 0x00019F5C
		public unsafe Material vestMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_vestMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_vestMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x060027F6 RID: 10230 RVA: 0x000A303C File Offset: 0x000A123C
		// (set) Token: 0x060027F7 RID: 10231 RVA: 0x0001BD7B File Offset: 0x00019F7B
		public unsafe Material gunMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_gunMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_gunMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x000A306C File Offset: 0x000A126C
		// (set) Token: 0x060027F9 RID: 10233 RVA: 0x0001BD9A File Offset: 0x00019F9A
		public unsafe Material fireBackpackMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_fireBackpackMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_fireBackpackMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x000A309C File Offset: 0x000A129C
		// (set) Token: 0x060027FB RID: 10235 RVA: 0x0001BDB9 File Offset: 0x00019FB9
		public unsafe Material shadowGrimeMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_shadowGrimeMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_shadowGrimeMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x000A30CC File Offset: 0x000A12CC
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x0001BDD8 File Offset: 0x00019FD8
		public unsafe Material halftoneMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_halftoneMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_halftoneMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x000A30FC File Offset: 0x000A12FC
		// (set) Token: 0x060027FF RID: 10239 RVA: 0x0001BDF7 File Offset: 0x00019FF7
		public unsafe Material woodMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_woodMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_woodMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x000A312C File Offset: 0x000A132C
		// (set) Token: 0x06002801 RID: 10241 RVA: 0x0001BE16 File Offset: 0x0001A016
		public unsafe Material treeMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_treeMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_treeMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x000A315C File Offset: 0x000A135C
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x0001BE35 File Offset: 0x0001A035
		public unsafe Material rockMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_rockMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_rockMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x000A318C File Offset: 0x000A138C
		// (set) Token: 0x06002805 RID: 10245 RVA: 0x0001BE54 File Offset: 0x0001A054
		public unsafe static PalleteMapper me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PalleteMapper.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PalleteMapper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PalleteMapper.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06002806 RID: 10246 RVA: 0x000A31B4 File Offset: 0x000A13B4
		// (set) Token: 0x06002807 RID: 10247 RVA: 0x0001BE66 File Offset: 0x0001A066
		public unsafe Il2CppReferenceArray<Texture> prePauseTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_prePauseTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteMapper.NativeFieldInfoPtr_prePauseTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeFieldInfoPtr_blueTex;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeFieldInfoPtr_blueSecondaryTex;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeFieldInfoPtr_greenTex;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeFieldInfoPtr_alarmTex;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeFieldInfoPtr_alarmSecondaryTex;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeFieldInfoPtr_lightsOutTex;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeFieldInfoPtr_bwTex;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeFieldInfoPtr_cityTex;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeFieldInfoPtr_buildingTex;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeFieldInfoPtr_bunkerTex;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeFieldInfoPtr_bunkerSecondaryTex;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeFieldInfoPtr_flameTex;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeFieldInfoPtr_flameSecondaryTex;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeFieldInfoPtr_stealthTex;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeFieldInfoPtr_stealthBoatTex;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeFieldInfoPtr_stealthSecondaryTex;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeFieldInfoPtr_outdoorTex;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeFieldInfoPtr_boatTex;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeFieldInfoPtr_boatDarkTex;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeFieldInfoPtr_mainRenderer;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeFieldInfoPtr_crazyTex;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeFieldInfoPtr_pauseTex;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeFieldInfoPtr_floorMat;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeFieldInfoPtr_shadowMat;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeFieldInfoPtr_guardMat;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeFieldInfoPtr_smokeMat;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeFieldInfoPtr_doorMat;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeFieldInfoPtr_glassMat;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeFieldInfoPtr_glassPartMat;

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeFieldInfoPtr_cageMat;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeFieldInfoPtr_apeMat;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeFieldInfoPtr_apeBloodMat;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeFieldInfoPtr_fireExtinguisherMat;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeFieldInfoPtr_tableMat;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeFieldInfoPtr_bloodMat;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeFieldInfoPtr_flashMat;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeFieldInfoPtr_vestMat;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeFieldInfoPtr_gunMat;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeFieldInfoPtr_fireBackpackMat;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeFieldInfoPtr_shadowGrimeMat;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeFieldInfoPtr_halftoneMat;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeFieldInfoPtr_woodMat;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeFieldInfoPtr_treeMat;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeFieldInfoPtr_rockMat;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeFieldInfoPtr_prePauseTex;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeMethodInfoPtr_UnPause_Public_Void_0;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeMethodInfoPtr_ChangePallete_Public_Void_String_0;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeMethodInfoPtr_SetTextures_Public_Void_Texture_Texture_Texture_0;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
