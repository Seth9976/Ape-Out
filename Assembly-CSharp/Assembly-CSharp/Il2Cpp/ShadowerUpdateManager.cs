using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000188 RID: 392
	public class ShadowerUpdateManager : MonoBehaviour
	{
		// Token: 0x06002EA2 RID: 11938 RVA: 0x000B4CBC File Offset: 0x000B2EBC
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowerUpdateManager()
		{
			Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ShadowerUpdateManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr);
			ShadowerUpdateManager.NativeFieldInfoPtr_updateList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr, "updateList");
			ShadowerUpdateManager.NativeFieldInfoPtr_rockUpdateList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr, "rockUpdateList");
			ShadowerUpdateManager.NativeFieldInfoPtr_m_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr, "m_instance");
			ShadowerUpdateManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_ShadowerUpdateManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr, 100666918);
			ShadowerUpdateManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr, 100666919);
			ShadowerUpdateManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr, 100666920);
			ShadowerUpdateManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr, 100666921);
			ShadowerUpdateManager.NativeMethodInfoPtr_AddRock_Public_Void_RockTech_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr, 100666922);
			ShadowerUpdateManager.NativeMethodInfoPtr_RemoveRock_Public_Void_RockTech_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr, 100666923);
			ShadowerUpdateManager.NativeMethodInfoPtr_AddShadower_Public_Void_Shadower_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr, 100666924);
			ShadowerUpdateManager.NativeMethodInfoPtr_RemoveShadower_Public_Void_Shadower_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr, 100666925);
			ShadowerUpdateManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr, 100666926);
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x000B4DDC File Offset: 0x000B2FDC
		public unsafe static ShadowerUpdateManager Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82564, XrefRangeEnd = 82566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowerUpdateManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_ShadowerUpdateManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShadowerUpdateManager>(intPtr3) : null;
			}
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000B4E10 File Offset: 0x000B3010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82566, XrefRangeEnd = 82568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowerUpdateManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x000B4E44 File Offset: 0x000B3044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82568, XrefRangeEnd = 82570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowerUpdateManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x000B4E78 File Offset: 0x000B3078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82570, XrefRangeEnd = 82578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowerUpdateManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x000B4EAC File Offset: 0x000B30AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82578, XrefRangeEnd = 82582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRock(RockTech shadower)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadower);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowerUpdateManager.NativeMethodInfoPtr_AddRock_Public_Void_RockTech_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x000B4EF0 File Offset: 0x000B30F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82582, XrefRangeEnd = 82584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRock(RockTech shadower)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadower);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowerUpdateManager.NativeMethodInfoPtr_RemoveRock_Public_Void_RockTech_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x000B4F34 File Offset: 0x000B3134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82584, XrefRangeEnd = 82588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddShadower(Shadower shadower)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadower);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowerUpdateManager.NativeMethodInfoPtr_AddShadower_Public_Void_Shadower_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x000B4F78 File Offset: 0x000B3178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82588, XrefRangeEnd = 82590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveShadower(Shadower shadower)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadower);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowerUpdateManager.NativeMethodInfoPtr_RemoveShadower_Public_Void_Shadower_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x000B4FBC File Offset: 0x000B31BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82590, XrefRangeEnd = 82605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadowerUpdateManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowerUpdateManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowerUpdateManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x000203DD File Offset: 0x0001E5DD
		public ShadowerUpdateManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x000B4FF8 File Offset: 0x000B31F8
		// (set) Token: 0x06002EAE RID: 11950 RVA: 0x000203E6 File Offset: 0x0001E5E6
		public unsafe List<Shadower> updateList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowerUpdateManager.NativeFieldInfoPtr_updateList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Shadower>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowerUpdateManager.NativeFieldInfoPtr_updateList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x000B5028 File Offset: 0x000B3228
		// (set) Token: 0x06002EB0 RID: 11952 RVA: 0x00020405 File Offset: 0x0001E605
		public unsafe List<RockTech> rockUpdateList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowerUpdateManager.NativeFieldInfoPtr_rockUpdateList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RockTech>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShadowerUpdateManager.NativeFieldInfoPtr_rockUpdateList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06002EB1 RID: 11953 RVA: 0x000B5058 File Offset: 0x000B3258
		// (set) Token: 0x06002EB2 RID: 11954 RVA: 0x00020424 File Offset: 0x0001E624
		public unsafe static ShadowerUpdateManager m_instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShadowerUpdateManager.NativeFieldInfoPtr_m_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShadowerUpdateManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowerUpdateManager.NativeFieldInfoPtr_m_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeFieldInfoPtr_updateList;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeFieldInfoPtr_rockUpdateList;

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeFieldInfoPtr_m_instance;

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ShadowerUpdateManager_0;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeMethodInfoPtr_AddRock_Public_Void_RockTech_0;

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRock_Public_Void_RockTech_0;

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeMethodInfoPtr_AddShadower_Public_Void_Shadower_0;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeMethodInfoPtr_RemoveShadower_Public_Void_Shadower_0;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
