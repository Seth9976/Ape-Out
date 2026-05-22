using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001CD RID: 461
	public class MethodBody : Object
	{
		// Token: 0x06001DD7 RID: 7639 RVA: 0x000AA7A8 File Offset: 0x000A89A8
		// Note: this type is marked as 'beforefieldinit'.
		static MethodBody()
		{
			Il2CppClassPointerStore<MethodBody>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MethodBody");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodBody>.NativeClassPtr);
			MethodBody.NativeFieldInfoPtr_clauses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, "clauses");
			MethodBody.NativeFieldInfoPtr_locals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, "locals");
			MethodBody.NativeFieldInfoPtr_il = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, "il");
			MethodBody.NativeFieldInfoPtr_init_locals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, "init_locals");
			MethodBody.NativeFieldInfoPtr_sig_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, "sig_token");
			MethodBody.NativeFieldInfoPtr_max_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, "max_stack");
			MethodBody.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, 100668323);
			MethodBody.NativeMethodInfoPtr_GetILAsByteArray_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBody>.NativeClassPtr, 100668324);
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x000AA878 File Offset: 0x000A8A78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodBody()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodBody>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBody.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x000AA8B4 File Offset: 0x000A8AB4
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetILAsByteArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBody.NativeMethodInfoPtr_GetILAsByteArray_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x0000A200 File Offset: 0x00008400
		public MethodBody(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x000AA900 File Offset: 0x000A8B00
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x0000A209 File Offset: 0x00008409
		public unsafe Il2CppReferenceArray<ExceptionHandlingClause> clauses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_clauses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExceptionHandlingClause>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_clauses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x000AA930 File Offset: 0x000A8B30
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x0000A228 File Offset: 0x00008428
		public unsafe Il2CppReferenceArray<LocalVariableInfo> locals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_locals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalVariableInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_locals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x000AA960 File Offset: 0x000A8B60
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x0000A247 File Offset: 0x00008447
		public unsafe Il2CppStructArray<byte> il
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_il);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_il), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x000AA990 File Offset: 0x000A8B90
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x0000A266 File Offset: 0x00008466
		public unsafe bool init_locals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_init_locals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_init_locals)) = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x000AA9B8 File Offset: 0x000A8BB8
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x0000A281 File Offset: 0x00008481
		public unsafe int sig_token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_sig_token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_sig_token)) = value;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x000AA9E0 File Offset: 0x000A8BE0
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x0000A29C File Offset: 0x0000849C
		public unsafe int max_stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_max_stack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBody.NativeFieldInfoPtr_max_stack)) = value;
			}
		}

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeFieldInfoPtr_clauses;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeFieldInfoPtr_locals;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeFieldInfoPtr_il;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeFieldInfoPtr_init_locals;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeFieldInfoPtr_sig_token;

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeFieldInfoPtr_max_stack;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeMethodInfoPtr_GetILAsByteArray_Public_Virtual_New_Il2CppStructArray_1_Byte_0;
	}
}
