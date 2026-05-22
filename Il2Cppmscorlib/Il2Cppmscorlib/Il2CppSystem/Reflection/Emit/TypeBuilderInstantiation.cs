using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x020001F6 RID: 502
	public class TypeBuilderInstantiation : TypeInfo
	{
		// Token: 0x0600205E RID: 8286 RVA: 0x0000ACE7 File Offset: 0x00008EE7
		// Note: this type is marked as 'beforefieldinit'.
		static TypeBuilderInstantiation()
		{
			Il2CppClassPointerStore<TypeBuilderInstantiation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "TypeBuilderInstantiation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeBuilderInstantiation>.NativeClassPtr);
			TypeBuilderInstantiation.NativeMethodInfoPtr_MakeGenericType_Internal_Static_Type_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeBuilderInstantiation>.NativeClassPtr, 100668761);
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x000B6BF4 File Offset: 0x000B4DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189404, XrefRangeEnd = 189410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type MakeGenericType(Type type, Il2CppReferenceArray<Type> typeArguments)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeBuilderInstantiation.NativeMethodInfoPtr_MakeGenericType_Internal_Static_Type_Type_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x0000AD20 File Offset: 0x00008F20
		public TypeBuilderInstantiation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenericType_Internal_Static_Type_Type_Il2CppReferenceArray_1_Type_0;
	}
}
