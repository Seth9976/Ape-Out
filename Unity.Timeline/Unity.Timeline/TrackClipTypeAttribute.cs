using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x0200003B RID: 59
	public class TrackClipTypeAttribute : Attribute
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x000167F4 File Offset: 0x000149F4
		// Note: this type is marked as 'beforefieldinit'.
		static TrackClipTypeAttribute()
		{
			Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TrackClipTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr);
			TrackClipTypeAttribute.NativeFieldInfoPtr_inspectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr, "inspectedType");
			TrackClipTypeAttribute.NativeFieldInfoPtr_allowAutoCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr, "allowAutoCreate");
			TrackClipTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr, 100664063);
			TrackClipTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr, 100664064);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00016874 File Offset: 0x00014A74
		[CallerCount(0)]
		public unsafe TrackClipTypeAttribute(Type clipClass)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clipClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackClipTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000168C0 File Offset: 0x00014AC0
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackClipTypeAttribute(Type clipClass, bool allowAutoCreate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackClipTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clipClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowAutoCreate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackClipTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000036FC File Offset: 0x000018FC
		public TrackClipTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0001691C File Offset: 0x00014B1C
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00003705 File Offset: 0x00001905
		public unsafe Type inspectedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackClipTypeAttribute.NativeFieldInfoPtr_inspectedType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackClipTypeAttribute.NativeFieldInfoPtr_inspectedType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0001694C File Offset: 0x00014B4C
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00003724 File Offset: 0x00001924
		public unsafe bool allowAutoCreate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackClipTypeAttribute.NativeFieldInfoPtr_allowAutoCreate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackClipTypeAttribute.NativeFieldInfoPtr_allowAutoCreate)) = value;
			}
		}

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_inspectedType;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeFieldInfoPtr_allowAutoCreate;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Boolean_0;
	}
}
