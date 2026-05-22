using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x02000011 RID: 17
	public class TrackColorAttribute : Attribute
	{
		// Token: 0x06000279 RID: 633 RVA: 0x0000E4C4 File Offset: 0x0000C6C4
		// Note: this type is marked as 'beforefieldinit'.
		static TrackColorAttribute()
		{
			Il2CppClassPointerStore<TrackColorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TrackColorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackColorAttribute>.NativeClassPtr);
			TrackColorAttribute.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackColorAttribute>.NativeClassPtr, "m_Color");
			TrackColorAttribute.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackColorAttribute>.NativeClassPtr, 100663734);
			TrackColorAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackColorAttribute>.NativeClassPtr, 100663735);
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000E530 File Offset: 0x0000C730
		public unsafe Color color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackColorAttribute.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000E56C File Offset: 0x0000C76C
		[CallerCount(0)]
		public unsafe TrackColorAttribute(float r, float g, float b)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackColorAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackColorAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002C32 File Offset: 0x00000E32
		public TrackColorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0000E5D0 File Offset: 0x0000C7D0
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00002C3B File Offset: 0x00000E3B
		public unsafe Color m_Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackColorAttribute.NativeFieldInfoPtr_m_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackColorAttribute.NativeFieldInfoPtr_m_Color)) = value;
			}
		}

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;
	}
}
