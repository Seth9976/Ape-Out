using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200019A RID: 410
	public sealed class AssemblyDelaySignAttribute : Attribute
	{
		// Token: 0x06001BEB RID: 7147 RVA: 0x000A2278 File Offset: 0x000A0478
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyDelaySignAttribute()
		{
			Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyDelaySignAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr);
			AssemblyDelaySignAttribute.NativeFieldInfoPtr_m_delaySign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr, "m_delaySign");
			AssemblyDelaySignAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr, 100668031);
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x000A22D0 File Offset: 0x000A04D0
		[CallerCount(0)]
		public unsafe AssemblyDelaySignAttribute(bool delaySign)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delaySign;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyDelaySignAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00009811 File Offset: 0x00007A11
		public AssemblyDelaySignAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x000A2318 File Offset: 0x000A0518
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x0000981A File Offset: 0x00007A1A
		public unsafe bool m_delaySign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDelaySignAttribute.NativeFieldInfoPtr_m_delaySign);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDelaySignAttribute.NativeFieldInfoPtr_m_delaySign)) = value;
			}
		}

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeFieldInfoPtr_m_delaySign;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
