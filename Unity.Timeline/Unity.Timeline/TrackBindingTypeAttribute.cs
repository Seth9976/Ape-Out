using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x0200003E RID: 62
	public class TrackBindingTypeAttribute : Attribute
	{
		// Token: 0x06000496 RID: 1174 RVA: 0x000169B0 File Offset: 0x00014BB0
		// Note: this type is marked as 'beforefieldinit'.
		static TrackBindingTypeAttribute()
		{
			Il2CppClassPointerStore<TrackBindingTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TrackBindingTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackBindingTypeAttribute>.NativeClassPtr);
			TrackBindingTypeAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackBindingTypeAttribute>.NativeClassPtr, "type");
			TrackBindingTypeAttribute.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackBindingTypeAttribute>.NativeClassPtr, "flags");
			TrackBindingTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackBindingTypeAttribute>.NativeClassPtr, 100664066);
			TrackBindingTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_TrackBindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackBindingTypeAttribute>.NativeClassPtr, 100664067);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00016A30 File Offset: 0x00014C30
		[CallerCount(0)]
		public unsafe TrackBindingTypeAttribute(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackBindingTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackBindingTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00016A7C File Offset: 0x00014C7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 22674, RefRangeEnd = 22677, XrefRangeStart = 22674, XrefRangeEnd = 22677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackBindingTypeAttribute(Type type, TrackBindingFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackBindingTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackBindingTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_TrackBindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00003781 File Offset: 0x00001981
		public TrackBindingTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00016AD8 File Offset: 0x00014CD8
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x0000378A File Offset: 0x0000198A
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackBindingTypeAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackBindingTypeAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00016B08 File Offset: 0x00014D08
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x000037A9 File Offset: 0x000019A9
		public unsafe TrackBindingFlags flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackBindingTypeAttribute.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackBindingTypeAttribute.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_TrackBindingFlags_0;
	}
}
