using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000034 RID: 52
	public class SECTR_AudioBus : ScriptableObject
	{
		// Token: 0x0600088D RID: 2189 RVA: 0x0004CF78 File Offset: 0x0004B178
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_AudioBus()
		{
			Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_AudioBus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr);
			SECTR_AudioBus.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, "parent");
			SECTR_AudioBus.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, "children");
			SECTR_AudioBus.NativeFieldInfoPtr_userVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, "userVolume");
			SECTR_AudioBus.NativeFieldInfoPtr_userPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, "userPitch");
			SECTR_AudioBus.NativeFieldInfoPtr_effectiveVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, "effectiveVolume");
			SECTR_AudioBus.NativeFieldInfoPtr_effectivePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, "effectivePitch");
			SECTR_AudioBus.NativeFieldInfoPtr_muted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, "muted");
			SECTR_AudioBus.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, "Volume");
			SECTR_AudioBus.NativeFieldInfoPtr_Pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, "Pitch");
			SECTR_AudioBus.NativeMethodInfoPtr_set_UserVolume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663912);
			SECTR_AudioBus.NativeMethodInfoPtr_get_UserVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663913);
			SECTR_AudioBus.NativeMethodInfoPtr_set_UserPitch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663914);
			SECTR_AudioBus.NativeMethodInfoPtr_get_UserPitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663915);
			SECTR_AudioBus.NativeMethodInfoPtr_get_Muted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663916);
			SECTR_AudioBus.NativeMethodInfoPtr_set_Muted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663917);
			SECTR_AudioBus.NativeMethodInfoPtr_get_EffectiveVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663918);
			SECTR_AudioBus.NativeMethodInfoPtr_set_EffectiveVolume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663919);
			SECTR_AudioBus.NativeMethodInfoPtr_get_EffectivePitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663920);
			SECTR_AudioBus.NativeMethodInfoPtr_set_EffectivePitch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663921);
			SECTR_AudioBus.NativeMethodInfoPtr_set_Parent_Public_set_Void_SECTR_AudioBus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663922);
			SECTR_AudioBus.NativeMethodInfoPtr_get_Parent_Public_get_SECTR_AudioBus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663923);
			SECTR_AudioBus.NativeMethodInfoPtr_get_Children_Public_get_List_1_SECTR_AudioBus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663924);
			SECTR_AudioBus.NativeMethodInfoPtr_IsAncestorOf_Public_Boolean_SECTR_AudioBus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663925);
			SECTR_AudioBus.NativeMethodInfoPtr_IsDecendentOf_Public_Boolean_SECTR_AudioBus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663926);
			SECTR_AudioBus.NativeMethodInfoPtr_ResetUserVolume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663927);
			SECTR_AudioBus.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663928);
			SECTR_AudioBus.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663929);
			SECTR_AudioBus.NativeMethodInfoPtr__AddChild_Private_Void_SECTR_AudioBus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663930);
			SECTR_AudioBus.NativeMethodInfoPtr__RemoveChild_Private_Void_SECTR_AudioBus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663931);
			SECTR_AudioBus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr, 100663932);
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x0004D240 File Offset: 0x0004B440
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x0004D200 File Offset: 0x0004B400
		public unsafe float UserVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_get_UserVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_set_UserVolume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x0004D2BC File Offset: 0x0004B4BC
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x0004D27C File Offset: 0x0004B47C
		public unsafe float UserPitch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_get_UserPitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_set_UserPitch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0004D2F8 File Offset: 0x0004B4F8
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x0004D334 File Offset: 0x0004B534
		public unsafe bool Muted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_get_Muted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_set_Muted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0004D374 File Offset: 0x0004B574
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x0004D3B0 File Offset: 0x0004B5B0
		public unsafe float EffectiveVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_get_EffectiveVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_set_EffectiveVolume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0004D3F0 File Offset: 0x0004B5F0
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x0004D42C File Offset: 0x0004B62C
		public unsafe float EffectivePitch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_get_EffectivePitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_set_EffectivePitch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x0004D4B0 File Offset: 0x0004B6B0
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x0004D46C File Offset: 0x0004B66C
		public unsafe SECTR_AudioBus Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_get_Parent_Public_get_SECTR_AudioBus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_AudioBus>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36999, XrefRangeEnd = 37039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_set_Parent_Public_set_Void_SECTR_AudioBus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x0004D4F0 File Offset: 0x0004B6F0
		public unsafe List<SECTR_AudioBus> Children
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_get_Children_Public_get_List_1_SECTR_AudioBus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_AudioBus>>(intPtr3) : null;
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0004D530 File Offset: 0x0004B730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37067, RefRangeEnd = 37068, XrefRangeStart = 37039, XrefRangeEnd = 37067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAncestorOf(SECTR_AudioBus bus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bus);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_IsAncestorOf_Public_Boolean_SECTR_AudioBus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0004D580 File Offset: 0x0004B780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37068, XrefRangeEnd = 37095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDecendentOf(SECTR_AudioBus bus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bus);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_IsDecendentOf_Public_Boolean_SECTR_AudioBus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0004D5D0 File Offset: 0x0004B7D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37102, RefRangeEnd = 37103, XrefRangeStart = 37095, XrefRangeEnd = 37102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetUserVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_ResetUserVolume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0004D604 File Offset: 0x0004B804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37103, XrefRangeEnd = 37108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0004D638 File Offset: 0x0004B838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37108, XrefRangeEnd = 37113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0004D66C File Offset: 0x0004B86C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37131, RefRangeEnd = 37133, XrefRangeStart = 37113, XrefRangeEnd = 37131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddChild(SECTR_AudioBus child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr__AddChild_Private_Void_SECTR_AudioBus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0004D6B0 File Offset: 0x0004B8B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37135, RefRangeEnd = 37137, XrefRangeStart = 37133, XrefRangeEnd = 37135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RemoveChild(SECTR_AudioBus child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr__RemoveChild_Private_Void_SECTR_AudioBus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0004D6F4 File Offset: 0x0004B8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37137, XrefRangeEnd = 37144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_AudioBus()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_AudioBus>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_AudioBus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00007AAA File Offset: 0x00005CAA
		public SECTR_AudioBus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0004D730 File Offset: 0x0004B930
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00007AB3 File Offset: 0x00005CB3
		public unsafe SECTR_AudioBus parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioBus>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0004D760 File Offset: 0x0004B960
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00007AD2 File Offset: 0x00005CD2
		public unsafe List<SECTR_AudioBus> children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_AudioBus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0004D790 File Offset: 0x0004B990
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00007AF1 File Offset: 0x00005CF1
		public unsafe float userVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_userVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_userVolume)) = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0004D7B8 File Offset: 0x0004B9B8
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00007B0C File Offset: 0x00005D0C
		public unsafe float userPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_userPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_userPitch)) = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0004D7E0 File Offset: 0x0004B9E0
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00007B27 File Offset: 0x00005D27
		public unsafe float effectiveVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_effectiveVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_effectiveVolume)) = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0004D808 File Offset: 0x0004BA08
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00007B42 File Offset: 0x00005D42
		public unsafe float effectivePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_effectivePitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_effectivePitch)) = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0004D830 File Offset: 0x0004BA30
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00007B5D File Offset: 0x00005D5D
		public unsafe bool muted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_muted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_muted)) = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0004D858 File Offset: 0x0004BA58
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00007B78 File Offset: 0x00005D78
		public unsafe float Volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_Volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_Volume)) = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0004D880 File Offset: 0x0004BA80
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00007B93 File Offset: 0x00005D93
		public unsafe float Pitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_Pitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_AudioBus.NativeFieldInfoPtr_Pitch)) = value;
			}
		}

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeFieldInfoPtr_userVolume;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeFieldInfoPtr_userPitch;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeFieldInfoPtr_effectiveVolume;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeFieldInfoPtr_effectivePitch;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeFieldInfoPtr_muted;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeFieldInfoPtr_Volume;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeFieldInfoPtr_Pitch;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_set_UserVolume_Public_set_Void_Single_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_get_UserVolume_Public_get_Single_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_set_UserPitch_Public_set_Void_Single_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_get_UserPitch_Public_get_Single_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_get_Muted_Public_get_Boolean_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_set_Muted_Public_set_Void_Boolean_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectiveVolume_Public_get_Single_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_set_EffectiveVolume_Public_set_Void_Single_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_get_EffectivePitch_Public_get_Single_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_set_EffectivePitch_Public_set_Void_Single_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Public_set_Void_SECTR_AudioBus_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_SECTR_AudioBus_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_List_1_SECTR_AudioBus_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_IsAncestorOf_Public_Boolean_SECTR_AudioBus_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_IsDecendentOf_Public_Boolean_SECTR_AudioBus_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_ResetUserVolume_Public_Void_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr__AddChild_Private_Void_SECTR_AudioBus_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr__RemoveChild_Private_Void_SECTR_AudioBus_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
