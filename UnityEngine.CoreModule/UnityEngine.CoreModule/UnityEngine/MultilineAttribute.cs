using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000B7 RID: 183
	public sealed class MultilineAttribute : PropertyAttribute
	{
		// Token: 0x06001184 RID: 4484 RVA: 0x00048384 File Offset: 0x00046584
		// Note: this type is marked as 'beforefieldinit'.
		static MultilineAttribute()
		{
			Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MultilineAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr);
			MultilineAttribute.NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr, "lines");
			MultilineAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr, 100664750);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x000483DC File Offset: 0x000465DC
		[CallerCount(0)]
		public unsafe MultilineAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultilineAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0000A437 File Offset: 0x00008637
		public MultilineAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00048418 File Offset: 0x00046618
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x0000A440 File Offset: 0x00008640
		public unsafe int lines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultilineAttribute.NativeFieldInfoPtr_lines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultilineAttribute.NativeFieldInfoPtr_lines)) = value;
			}
		}

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeFieldInfoPtr_lines;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
