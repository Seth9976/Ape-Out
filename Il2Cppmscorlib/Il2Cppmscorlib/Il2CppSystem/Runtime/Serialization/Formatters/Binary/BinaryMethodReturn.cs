using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035B RID: 859
	public sealed class BinaryMethodReturn : Object
	{
		// Token: 0x060037B9 RID: 14265 RVA: 0x0010FCC4 File Offset: 0x0010DEC4
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryMethodReturn()
		{
			Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryMethodReturn");
			BinaryMethodReturn.NativeFieldInfoPtr_returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "returnValue");
			BinaryMethodReturn.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "args");
			BinaryMethodReturn.NativeFieldInfoPtr_callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "callContext");
			BinaryMethodReturn.NativeFieldInfoPtr_argTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "argTypes");
			BinaryMethodReturn.NativeFieldInfoPtr_bArgsPrimitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "bArgsPrimitive");
			BinaryMethodReturn.NativeFieldInfoPtr_messageEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "messageEnum");
			BinaryMethodReturn.NativeFieldInfoPtr_returnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "returnType");
			BinaryMethodReturn.NativeFieldInfoPtr_instanceOfVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, "instanceOfVoid");
			BinaryMethodReturn.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, 100671902);
			BinaryMethodReturn.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, 100671903);
			BinaryMethodReturn.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr, 100671904);
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x0010FDC8 File Offset: 0x0010DFC8
		[CallerCount(0)]
		public unsafe BinaryMethodReturn()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryMethodReturn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodReturn.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x0010FE04 File Offset: 0x0010E004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215835, RefRangeEnd = 215836, XrefRangeStart = 215819, XrefRangeEnd = 215835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodReturn.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x0010FE48 File Offset: 0x0010E048
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryMethodReturn.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00013E36 File Offset: 0x00012036
		public BinaryMethodReturn(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x0010FE7C File Offset: 0x0010E07C
		// (set) Token: 0x060037BF RID: 14271 RVA: 0x00013E3F File Offset: 0x0001203F
		public unsafe Object returnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_returnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_returnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x0010FEAC File Offset: 0x0010E0AC
		// (set) Token: 0x060037C1 RID: 14273 RVA: 0x00013E5E File Offset: 0x0001205E
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x060037C2 RID: 14274 RVA: 0x0010FEDC File Offset: 0x0010E0DC
		// (set) Token: 0x060037C3 RID: 14275 RVA: 0x00013E7D File Offset: 0x0001207D
		public unsafe Object callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x0010FF0C File Offset: 0x0010E10C
		// (set) Token: 0x060037C5 RID: 14277 RVA: 0x00013E9C File Offset: 0x0001209C
		public unsafe Il2CppReferenceArray<Type> argTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_argTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_argTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x0010FF3C File Offset: 0x0010E13C
		// (set) Token: 0x060037C7 RID: 14279 RVA: 0x00013EBB File Offset: 0x000120BB
		public unsafe bool bArgsPrimitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_bArgsPrimitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_bArgsPrimitive)) = value;
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x060037C8 RID: 14280 RVA: 0x0010FF64 File Offset: 0x0010E164
		// (set) Token: 0x060037C9 RID: 14281 RVA: 0x00013ED6 File Offset: 0x000120D6
		public unsafe MessageEnum messageEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_messageEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_messageEnum)) = value;
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x060037CA RID: 14282 RVA: 0x0010FF8C File Offset: 0x0010E18C
		// (set) Token: 0x060037CB RID: 14283 RVA: 0x00013EF1 File Offset: 0x000120F1
		public unsafe Type returnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_returnType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryMethodReturn.NativeFieldInfoPtr_returnType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x060037CC RID: 14284 RVA: 0x0010FFBC File Offset: 0x0010E1BC
		// (set) Token: 0x060037CD RID: 14285 RVA: 0x00013F10 File Offset: 0x00012110
		public unsafe static Object instanceOfVoid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinaryMethodReturn.NativeFieldInfoPtr_instanceOfVoid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryMethodReturn.NativeFieldInfoPtr_instanceOfVoid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002ED5 RID: 11989
		private static readonly IntPtr NativeFieldInfoPtr_returnValue;

		// Token: 0x04002ED6 RID: 11990
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04002ED7 RID: 11991
		private static readonly IntPtr NativeFieldInfoPtr_callContext;

		// Token: 0x04002ED8 RID: 11992
		private static readonly IntPtr NativeFieldInfoPtr_argTypes;

		// Token: 0x04002ED9 RID: 11993
		private static readonly IntPtr NativeFieldInfoPtr_bArgsPrimitive;

		// Token: 0x04002EDA RID: 11994
		private static readonly IntPtr NativeFieldInfoPtr_messageEnum;

		// Token: 0x04002EDB RID: 11995
		private static readonly IntPtr NativeFieldInfoPtr_returnType;

		// Token: 0x04002EDC RID: 11996
		private static readonly IntPtr NativeFieldInfoPtr_instanceOfVoid;

		// Token: 0x04002EDD RID: 11997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002EDE RID: 11998
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002EDF RID: 11999
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
