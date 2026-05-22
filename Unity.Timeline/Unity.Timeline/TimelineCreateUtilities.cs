using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Timeline
{
	// Token: 0x0200004E RID: 78
	public static class TimelineCreateUtilities : Object
	{
		// Token: 0x06000519 RID: 1305 RVA: 0x000189D0 File Offset: 0x00016BD0
		// Note: this type is marked as 'beforefieldinit'.
		static TimelineCreateUtilities()
		{
			Il2CppClassPointerStore<TimelineCreateUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimelineCreateUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineCreateUtilities>.NativeClassPtr);
			TimelineCreateUtilities.NativeMethodInfoPtr_GenerateUniqueActorName_Public_Static_String_List_1_ScriptableObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineCreateUtilities>.NativeClassPtr, 100664139);
			TimelineCreateUtilities.NativeMethodInfoPtr_SaveAssetIntoObject_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineCreateUtilities>.NativeClassPtr, 100664140);
			TimelineCreateUtilities.NativeMethodInfoPtr_CreateAnimationClipForTrack_Public_Static_AnimationClip_String_TrackAsset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineCreateUtilities>.NativeClassPtr, 100664141);
			TimelineCreateUtilities.NativeMethodInfoPtr_ValidateParentTrack_Public_Static_Boolean_TrackAsset_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineCreateUtilities>.NativeClassPtr, 100664142);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00018A50 File Offset: 0x00016C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480163, RefRangeEnd = 480164, XrefRangeStart = 480129, XrefRangeEnd = 480163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GenerateUniqueActorName(List<ScriptableObject> tracks, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tracks);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineCreateUtilities.NativeMethodInfoPtr_GenerateUniqueActorName_Public_Static_String_List_1_ScriptableObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00018AA0 File Offset: 0x00016CA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 480194, RefRangeEnd = 480199, XrefRangeStart = 480164, XrefRangeEnd = 480194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SaveAssetIntoObject(Object childAsset, Object masterAsset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childAsset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(masterAsset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineCreateUtilities.NativeMethodInfoPtr_SaveAssetIntoObject_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00018AE8 File Offset: 0x00016CE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 480260, RefRangeEnd = 480264, XrefRangeStart = 480199, XrefRangeEnd = 480260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationClip CreateAnimationClipForTrack(string name, TrackAsset track, bool isLegacy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(track);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLegacy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineCreateUtilities.NativeMethodInfoPtr_CreateAnimationClipForTrack_Public_Static_AnimationClip_String_TrackAsset_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr3) : null;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00018B4C File Offset: 0x00016D4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 480323, RefRangeEnd = 480324, XrefRangeStart = 480264, XrefRangeEnd = 480323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidateParentTrack(TrackAsset parent, Type childType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineCreateUtilities.NativeMethodInfoPtr_ValidateParentTrack_Public_Static_Boolean_TrackAsset_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00003AD9 File Offset: 0x00001CD9
		public TimelineCreateUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_GenerateUniqueActorName_Public_Static_String_List_1_ScriptableObject_String_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_SaveAssetIntoObject_Public_Static_Void_Object_Object_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_CreateAnimationClipForTrack_Public_Static_AnimationClip_String_TrackAsset_Boolean_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_ValidateParentTrack_Public_Static_Boolean_TrackAsset_Type_0;

		// Token: 0x0200007C RID: 124
		[ObfuscatedName("UnityEngine.Timeline.TimelineCreateUtilities+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x0600062F RID: 1583 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<TimelineCreateUtilities.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimelineCreateUtilities>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineCreateUtilities.__c__DisplayClass0_0>.NativeClassPtr);
				TimelineCreateUtilities.__c__DisplayClass0_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineCreateUtilities.__c__DisplayClass0_0>.NativeClassPtr, "name");
				TimelineCreateUtilities.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineCreateUtilities.__c__DisplayClass0_0>.NativeClassPtr, 100664143);
				TimelineCreateUtilities.__c__DisplayClass0_0.NativeMethodInfoPtr__GenerateUniqueActorName_b__0_Internal_Boolean_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineCreateUtilities.__c__DisplayClass0_0>.NativeClassPtr, 100664144);
			}

			// Token: 0x06000630 RID: 1584 RVA: 0x0001C040 File Offset: 0x0001A240
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineCreateUtilities.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineCreateUtilities.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000631 RID: 1585 RVA: 0x0001C07C File Offset: 0x0001A27C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480128, XrefRangeEnd = 480129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateUniqueActorName_b__0(ScriptableObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineCreateUtilities.__c__DisplayClass0_0.NativeMethodInfoPtr__GenerateUniqueActorName_b__0_Internal_Boolean_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000632 RID: 1586 RVA: 0x0000433A File Offset: 0x0000253A
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001E0 RID: 480
			// (get) Token: 0x06000633 RID: 1587 RVA: 0x0001C0CC File Offset: 0x0001A2CC
			// (set) Token: 0x06000634 RID: 1588 RVA: 0x00004343 File Offset: 0x00002543
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineCreateUtilities.__c__DisplayClass0_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineCreateUtilities.__c__DisplayClass0_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004C8 RID: 1224
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040004C9 RID: 1225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004CA RID: 1226
			private static readonly IntPtr NativeMethodInfoPtr__GenerateUniqueActorName_b__0_Internal_Boolean_ScriptableObject_0;
		}

		// Token: 0x0200007D RID: 125
		[ObfuscatedName("UnityEngine.Timeline.TimelineCreateUtilities+<>c__DisplayClass0_1")]
		public sealed class __c__DisplayClass0_1 : Object
		{
			// Token: 0x06000635 RID: 1589 RVA: 0x0001C0F4 File Offset: 0x0001A2F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_1()
			{
				Il2CppClassPointerStore<TimelineCreateUtilities.__c__DisplayClass0_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimelineCreateUtilities>.NativeClassPtr, "<>c__DisplayClass0_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineCreateUtilities.__c__DisplayClass0_1>.NativeClassPtr);
				TimelineCreateUtilities.__c__DisplayClass0_1.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineCreateUtilities.__c__DisplayClass0_1>.NativeClassPtr, "result");
				TimelineCreateUtilities.__c__DisplayClass0_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineCreateUtilities.__c__DisplayClass0_1>.NativeClassPtr, 100664145);
				TimelineCreateUtilities.__c__DisplayClass0_1.NativeMethodInfoPtr__GenerateUniqueActorName_b__1_Internal_Boolean_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineCreateUtilities.__c__DisplayClass0_1>.NativeClassPtr, 100664146);
			}

			// Token: 0x06000636 RID: 1590 RVA: 0x0001C15C File Offset: 0x0001A35C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineCreateUtilities.__c__DisplayClass0_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineCreateUtilities.__c__DisplayClass0_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000637 RID: 1591 RVA: 0x0001C198 File Offset: 0x0001A398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateUniqueActorName_b__1(ScriptableObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimelineCreateUtilities.__c__DisplayClass0_1.NativeMethodInfoPtr__GenerateUniqueActorName_b__1_Internal_Boolean_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000638 RID: 1592 RVA: 0x00004362 File Offset: 0x00002562
			public __c__DisplayClass0_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001E1 RID: 481
			// (get) Token: 0x06000639 RID: 1593 RVA: 0x0001C1E8 File Offset: 0x0001A3E8
			// (set) Token: 0x0600063A RID: 1594 RVA: 0x0000436B File Offset: 0x0000256B
			public unsafe string result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineCreateUtilities.__c__DisplayClass0_1.NativeFieldInfoPtr_result);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimelineCreateUtilities.__c__DisplayClass0_1.NativeFieldInfoPtr_result), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004CB RID: 1227
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x040004CC RID: 1228
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004CD RID: 1229
			private static readonly IntPtr NativeMethodInfoPtr__GenerateUniqueActorName_b__1_Internal_Boolean_ScriptableObject_0;
		}
	}
}
