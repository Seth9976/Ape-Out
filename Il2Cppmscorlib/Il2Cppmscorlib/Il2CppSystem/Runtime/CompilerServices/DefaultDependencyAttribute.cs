using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000428 RID: 1064
	[Serializable]
	public sealed class DefaultDependencyAttribute : Attribute
	{
		// Token: 0x0600432A RID: 17194 RVA: 0x00137730 File Offset: 0x00135930
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultDependencyAttribute()
		{
			Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DefaultDependencyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr);
			DefaultDependencyAttribute.NativeFieldInfoPtr_loadHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr, "loadHint");
			DefaultDependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_LoadHint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr, 100673124);
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x00137788 File Offset: 0x00135988
		[CallerCount(0)]
		public unsafe DefaultDependencyAttribute(LoadHint loadHintArgument)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loadHintArgument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDependencyAttribute.NativeMethodInfoPtr__ctor_Public_Void_LoadHint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x000196E1 File Offset: 0x000178E1
		public DefaultDependencyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x0600432D RID: 17197 RVA: 0x001377D0 File Offset: 0x001359D0
		// (set) Token: 0x0600432E RID: 17198 RVA: 0x000196EA File Offset: 0x000178EA
		public unsafe LoadHint loadHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDependencyAttribute.NativeFieldInfoPtr_loadHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDependencyAttribute.NativeFieldInfoPtr_loadHint)) = value;
			}
		}

		// Token: 0x040036A4 RID: 13988
		private static readonly IntPtr NativeFieldInfoPtr_loadHint;

		// Token: 0x040036A5 RID: 13989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoadHint_0;
	}
}
