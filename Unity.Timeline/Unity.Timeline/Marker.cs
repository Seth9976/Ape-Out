using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Timeline
{
	// Token: 0x02000025 RID: 37
	public class Marker : ScriptableObject
	{
		// Token: 0x0600039E RID: 926 RVA: 0x00012BD4 File Offset: 0x00010DD4
		// Note: this type is marked as 'beforefieldinit'.
		static Marker()
		{
			Il2CppClassPointerStore<Marker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "Marker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Marker>.NativeClassPtr);
			Marker.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marker>.NativeClassPtr, "m_Time");
			Marker.NativeFieldInfoPtr__parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marker>.NativeClassPtr, "<parent>k__BackingField");
			Marker.NativeMethodInfoPtr_get_parent_Public_Virtual_Final_New_get_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marker>.NativeClassPtr, 100663916);
			Marker.NativeMethodInfoPtr_set_parent_Private_set_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marker>.NativeClassPtr, 100663917);
			Marker.NativeMethodInfoPtr_get_time_Public_Virtual_Final_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marker>.NativeClassPtr, 100663918);
			Marker.NativeMethodInfoPtr_set_time_Public_Virtual_Final_New_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marker>.NativeClassPtr, 100663919);
			Marker.NativeMethodInfoPtr_UnityEngine_Timeline_IMarker_Initialize_Private_Virtual_Final_New_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marker>.NativeClassPtr, 100663920);
			Marker.NativeMethodInfoPtr_OnInitialize_Public_Virtual_New_Void_TrackAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marker>.NativeClassPtr, 100663921);
			Marker.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marker>.NativeClassPtr, 100663922);
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00012CB8 File Offset: 0x00010EB8
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00012CF8 File Offset: 0x00010EF8
		public unsafe virtual TrackAsset parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marker.NativeMethodInfoPtr_get_parent_Public_Virtual_Final_New_get_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marker.NativeMethodInfoPtr_set_parent_Private_set_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00012D3C File Offset: 0x00010F3C
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00012D78 File Offset: 0x00010F78
		public unsafe virtual double time
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marker.NativeMethodInfoPtr_get_time_Public_Virtual_Final_New_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477852, XrefRangeEnd = 477856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marker.NativeMethodInfoPtr_set_time_Public_Virtual_Final_New_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00012DB8 File Offset: 0x00010FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 477856, XrefRangeEnd = 477874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_Timeline_IMarker_Initialize(TrackAsset parentTrack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentTrack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marker.NativeMethodInfoPtr_UnityEngine_Timeline_IMarker_Initialize_Private_Virtual_Final_New_Void_TrackAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00012DFC File Offset: 0x00010FFC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInitialize(TrackAsset aPent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aPent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Marker.NativeMethodInfoPtr_OnInitialize_Public_Virtual_New_Void_TrackAsset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00012E4C File Offset: 0x0001104C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Marker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Marker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Marker.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000324C File Offset: 0x0000144C
		public Marker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00012E88 File Offset: 0x00011088
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x00003255 File Offset: 0x00001455
		public unsafe double m_Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marker.NativeFieldInfoPtr_m_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marker.NativeFieldInfoPtr_m_Time)) = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00012EB0 File Offset: 0x000110B0
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00003270 File Offset: 0x00001470
		public unsafe TrackAsset _parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marker.NativeFieldInfoPtr__parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Marker.NativeFieldInfoPtr__parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_m_Time;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr__parent_k__BackingField;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_get_parent_Public_Virtual_Final_New_get_TrackAsset_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_set_parent_Private_set_Void_TrackAsset_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_Virtual_Final_New_get_Double_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_Virtual_Final_New_set_Void_Double_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_IMarker_Initialize_Private_Virtual_Final_New_Void_TrackAsset_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Public_Virtual_New_Void_TrackAsset_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
