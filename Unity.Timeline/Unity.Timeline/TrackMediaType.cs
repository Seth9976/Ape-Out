using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x0200003A RID: 58
	public class TrackMediaType : Attribute
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x0001672C File Offset: 0x0001492C
		// Note: this type is marked as 'beforefieldinit'.
		static TrackMediaType()
		{
			Il2CppClassPointerStore<TrackMediaType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TrackMediaType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackMediaType>.NativeClassPtr);
			TrackMediaType.NativeFieldInfoPtr_m_MediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackMediaType>.NativeClassPtr, "m_MediaType");
			TrackMediaType.NativeMethodInfoPtr__ctor_Public_Void_MediaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackMediaType>.NativeClassPtr, 100664062);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00016784 File Offset: 0x00014984
		[CallerCount(0)]
		public unsafe TrackMediaType(TimelineAsset.MediaType mt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackMediaType>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackMediaType.NativeMethodInfoPtr__ctor_Public_Void_MediaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000036D8 File Offset: 0x000018D8
		public TrackMediaType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x000167CC File Offset: 0x000149CC
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x000036E1 File Offset: 0x000018E1
		public unsafe TimelineAsset.MediaType m_MediaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackMediaType.NativeFieldInfoPtr_m_MediaType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackMediaType.NativeFieldInfoPtr_m_MediaType)) = value;
			}
		}

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeFieldInfoPtr_m_MediaType;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MediaType_0;
	}
}
