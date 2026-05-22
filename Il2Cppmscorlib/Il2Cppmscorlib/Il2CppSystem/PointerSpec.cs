using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000145 RID: 325
	public class PointerSpec : Object
	{
		// Token: 0x06001704 RID: 5892 RVA: 0x0008BE4C File Offset: 0x0008A04C
		// Note: this type is marked as 'beforefieldinit'.
		static PointerSpec()
		{
			Il2CppClassPointerStore<PointerSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "PointerSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr);
			PointerSpec.NativeFieldInfoPtr_pointer_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, "pointer_level");
			PointerSpec.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, 100667222);
			PointerSpec.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, 100667223);
			PointerSpec.NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, 100667224);
			PointerSpec.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr, 100667225);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x0008BEE0 File Offset: 0x0008A0E0
		[CallerCount(0)]
		public unsafe PointerSpec(int pointer_level)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerSpec>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointer_level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerSpec.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x0008BF28 File Offset: 0x0008A128
		[CallerCount(0)]
		public unsafe virtual Type Resolve(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerSpec.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x0008BF78 File Offset: 0x0008A178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178640, XrefRangeEnd = 178642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual StringBuilder Append(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerSpec.NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x0008BFC8 File Offset: 0x0008A1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178642, XrefRangeEnd = 178651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerSpec.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00007FE5 File Offset: 0x000061E5
		public PointerSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x0008C00C File Offset: 0x0008A20C
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x00007FEE File Offset: 0x000061EE
		public unsafe int pointer_level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerSpec.NativeFieldInfoPtr_pointer_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerSpec.NativeFieldInfoPtr_pointer_level)) = value;
			}
		}

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeFieldInfoPtr_pointer_level;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
