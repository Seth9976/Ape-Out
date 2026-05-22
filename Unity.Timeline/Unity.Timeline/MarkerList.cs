using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000026 RID: 38
	[Serializable]
	public sealed class MarkerList : ValueType
	{
		// Token: 0x060003AB RID: 939 RVA: 0x00012EE0 File Offset: 0x000110E0
		// Note: this type is marked as 'beforefieldinit'.
		static MarkerList()
		{
			Il2CppClassPointerStore<MarkerList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "MarkerList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarkerList>.NativeClassPtr);
			MarkerList.NativeFieldInfoPtr_m_Objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, "m_Objects");
			MarkerList.NativeFieldInfoPtr_m_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, "m_Cache");
			MarkerList.NativeFieldInfoPtr_m_CacheDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, "m_CacheDirty");
			MarkerList.NativeFieldInfoPtr_m_HasNotifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, "m_HasNotifications");
			MarkerList.NativeMethodInfoPtr_get_markers_Public_get_List_1_IMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663923);
			MarkerList.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663924);
			MarkerList.NativeMethodInfoPtr_Add_Public_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663925);
			MarkerList.NativeMethodInfoPtr_Remove_Public_Boolean_IMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663926);
			MarkerList.NativeMethodInfoPtr_Remove_Public_Boolean_ScriptableObject_TimelineAsset_PlayableAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663927);
			MarkerList.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663928);
			MarkerList.NativeMethodInfoPtr_Contains_Public_Boolean_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663929);
			MarkerList.NativeMethodInfoPtr_GetMarkers_Public_IEnumerable_1_IMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663930);
			MarkerList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663931);
			MarkerList.NativeMethodInfoPtr_get_Item_Public_get_IMarker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663932);
			MarkerList.NativeMethodInfoPtr_GetRawMarkerList_Public_List_1_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663933);
			MarkerList.NativeMethodInfoPtr_CreateMarker_Public_IMarker_Type_Double_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663934);
			MarkerList.NativeMethodInfoPtr_HasNotifications_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663935);
			MarkerList.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663936);
			MarkerList.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663937);
			MarkerList.NativeMethodInfoPtr_BuildCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkerList>.NativeClassPtr, 100663938);
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003AC RID: 940 RVA: 0x000130A0 File Offset: 0x000112A0
		public unsafe List<IMarker> markers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477874, XrefRangeEnd = 477875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_get_markers_Public_get_List_1_IMarker_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IMarker>>(intPtr3) : null;
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000130E4 File Offset: 0x000112E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477887, RefRangeEnd = 477888, XrefRangeStart = 477875, XrefRangeEnd = 477887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarkerList(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarkerList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00013130 File Offset: 0x00011330
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477903, RefRangeEnd = 477905, XrefRangeStart = 477888, XrefRangeEnd = 477903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(ScriptableObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_Add_Public_Void_ScriptableObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00013178 File Offset: 0x00011378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477915, RefRangeEnd = 477916, XrefRangeStart = 477905, XrefRangeEnd = 477915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(IMarker item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_Remove_Public_Boolean_IMarker_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000131CC File Offset: 0x000113CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477922, RefRangeEnd = 477924, XrefRangeStart = 477916, XrefRangeEnd = 477922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(timelineAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thingToDirty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_Remove_Public_Boolean_ScriptableObject_TimelineAsset_PlayableAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00013244 File Offset: 0x00011444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477926, RefRangeEnd = 477927, XrefRangeStart = 477924, XrefRangeEnd = 477926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0001327C File Offset: 0x0001147C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477927, XrefRangeEnd = 477931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(ScriptableObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_Contains_Public_Boolean_ScriptableObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000132D0 File Offset: 0x000114D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IMarker> GetMarkers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_GetMarkers_Public_IEnumerable_1_IMarker_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IMarker>>(intPtr3) : null;
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00013314 File Offset: 0x00011514
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477931, XrefRangeEnd = 477933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000155 RID: 341
		public unsafe IMarker this[int idx]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 477935, RefRangeEnd = 477936, XrefRangeStart = 477933, XrefRangeEnd = 477935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref idx;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_get_Item_Public_get_IMarker_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMarker>(intPtr3) : null;
				}
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000133AC File Offset: 0x000115AC
		[CallerCount(0)]
		public unsafe List<ScriptableObject> GetRawMarkerList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_GetRawMarkerList_Public_List_1_ScriptableObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ScriptableObject>>(intPtr3) : null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000133F0 File Offset: 0x000115F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477963, RefRangeEnd = 477965, XrefRangeStart = 477936, XrefRangeEnd = 477963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMarker CreateMarker(Type type, double time, TrackAsset owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_CreateMarker_Public_IMarker_Type_Double_TrackAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMarker>(intPtr3) : null;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00013468 File Offset: 0x00011668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477965, XrefRangeEnd = 477966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_HasNotifications_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000134AC File Offset: 0x000116AC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000134E4 File Offset: 0x000116E4
		[CallerCount(0)]
		public unsafe void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0001351C File Offset: 0x0001171C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 478002, RefRangeEnd = 478017, XrefRangeStart = 477966, XrefRangeEnd = 478002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarkerList.NativeMethodInfoPtr_BuildCache_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000328F File Offset: 0x0000148F
		public MarkerList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00003298 File Offset: 0x00001498
		public MarkerList()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarkerList>.NativeClassPtr))
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00013554 File Offset: 0x00011754
		// (set) Token: 0x060003BF RID: 959 RVA: 0x000032AA File Offset: 0x000014AA
		public unsafe List<ScriptableObject> m_Objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarkerList.NativeFieldInfoPtr_m_Objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScriptableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarkerList.NativeFieldInfoPtr_m_Objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00013584 File Offset: 0x00011784
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x000032C9 File Offset: 0x000014C9
		public unsafe List<IMarker> m_Cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarkerList.NativeFieldInfoPtr_m_Cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IMarker>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarkerList.NativeFieldInfoPtr_m_Cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x000135B4 File Offset: 0x000117B4
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x000032E8 File Offset: 0x000014E8
		public unsafe bool m_CacheDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarkerList.NativeFieldInfoPtr_m_CacheDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarkerList.NativeFieldInfoPtr_m_CacheDirty)) = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000135DC File Offset: 0x000117DC
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00003303 File Offset: 0x00001503
		public unsafe bool m_HasNotifications
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarkerList.NativeFieldInfoPtr_m_HasNotifications);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarkerList.NativeFieldInfoPtr_m_HasNotifications)) = value;
			}
		}

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_m_Objects;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_m_Cache;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheDirty;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_m_HasNotifications;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_get_markers_Public_get_List_1_IMarker_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_ScriptableObject_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_IMarker_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_ScriptableObject_TimelineAsset_PlayableAsset_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_ScriptableObject_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_GetMarkers_Public_IEnumerable_1_IMarker_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_IMarker_Int32_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_GetRawMarkerList_Public_List_1_ScriptableObject_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarker_Public_IMarker_Type_Double_TrackAsset_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_HasNotifications_Public_Boolean_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_BuildCache_Private_Void_0;
	}
}
