using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035A RID: 858
	public sealed class BinaryMethodCall : Object
	{
		// Token: 0x060037A6 RID: 14246 RVA: 0x0010F9E8 File Offset: 0x0010DBE8
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryMethodCall()
		{
			Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryMethodCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr);
			BinaryMethodCall.NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "methodName");
			BinaryMethodCall.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "typeName");
			BinaryMethodCall.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "args");
			BinaryMethodCall.NativeFieldInfoPtr_callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "callContext");
			BinaryMethodCall.NativeFieldInfoPtr_argTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "argTypes");
			BinaryMethodCall.NativeFieldInfoPtr_bArgsPrimitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "bArgsPrimitive");
			BinaryMethodCall.NativeFieldInfoPtr_messageEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, "messageEnum");
			BinaryMethodCall.NativeMethodInfoPtr_Write_Internal_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, 100671898);
			BinaryMethodCall.NativeMethodInfoPtr_Dump_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, 100671899);
			BinaryMethodCall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr, 100671900);
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x0010FAE0 File Offset: 0x0010DCE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215818, RefRangeEnd = 215819, XrefRangeStart = 215801, XrefRangeEnd = 215818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodCall.NativeMethodInfoPtr_Write_Internal_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x0010FB24 File Offset: 0x0010DD24
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodCall.NativeMethodInfoPtr_Dump_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x0010FB58 File Offset: 0x0010DD58
		[CallerCount(0)]
		public unsafe BinaryMethodCall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryMethodCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodCall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x00013D5C File Offset: 0x00011F5C
		public BinaryMethodCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x060037AB RID: 14251 RVA: 0x0010FB94 File Offset: 0x0010DD94
		// (set) Token: 0x060037AC RID: 14252 RVA: 0x00013D65 File Offset: 0x00011F65
		public unsafe string methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x060037AD RID: 14253 RVA: 0x0010FBBC File Offset: 0x0010DDBC
		// (set) Token: 0x060037AE RID: 14254 RVA: 0x00013D84 File Offset: 0x00011F84
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x060037AF RID: 14255 RVA: 0x0010FBE4 File Offset: 0x0010DDE4
		// (set) Token: 0x060037B0 RID: 14256 RVA: 0x00013DA3 File Offset: 0x00011FA3
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x060037B1 RID: 14257 RVA: 0x0010FC14 File Offset: 0x0010DE14
		// (set) Token: 0x060037B2 RID: 14258 RVA: 0x00013DC2 File Offset: 0x00011FC2
		public unsafe Object callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x060037B3 RID: 14259 RVA: 0x0010FC44 File Offset: 0x0010DE44
		// (set) Token: 0x060037B4 RID: 14260 RVA: 0x00013DE1 File Offset: 0x00011FE1
		public unsafe Il2CppReferenceArray<Type> argTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_argTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_argTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x060037B5 RID: 14261 RVA: 0x0010FC74 File Offset: 0x0010DE74
		// (set) Token: 0x060037B6 RID: 14262 RVA: 0x00013E00 File Offset: 0x00012000
		public unsafe bool bArgsPrimitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_bArgsPrimitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_bArgsPrimitive)) = value;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x060037B7 RID: 14263 RVA: 0x0010FC9C File Offset: 0x0010DE9C
		// (set) Token: 0x060037B8 RID: 14264 RVA: 0x00013E1B File Offset: 0x0001201B
		public unsafe MessageEnum messageEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_messageEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodCall.NativeFieldInfoPtr_messageEnum)) = value;
			}
		}

		// Token: 0x04002ECB RID: 11979
		private static readonly IntPtr NativeFieldInfoPtr_methodName;

		// Token: 0x04002ECC RID: 11980
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04002ECD RID: 11981
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04002ECE RID: 11982
		private static readonly IntPtr NativeFieldInfoPtr_callContext;

		// Token: 0x04002ECF RID: 11983
		private static readonly IntPtr NativeFieldInfoPtr_argTypes;

		// Token: 0x04002ED0 RID: 11984
		private static readonly IntPtr NativeFieldInfoPtr_bArgsPrimitive;

		// Token: 0x04002ED1 RID: 11985
		private static readonly IntPtr NativeFieldInfoPtr_messageEnum;

		// Token: 0x04002ED2 RID: 11986
		private static readonly IntPtr NativeMethodInfoPtr_Write_Internal_Void___BinaryWriter_0;

		// Token: 0x04002ED3 RID: 11987
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Internal_Void_0;

		// Token: 0x04002ED4 RID: 11988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
