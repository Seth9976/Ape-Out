using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E9 RID: 1001
	public class CADMessageBase : Object
	{
		// Token: 0x06004075 RID: 16501 RVA: 0x0012D6E8 File Offset: 0x0012B8E8
		// Note: this type is marked as 'beforefieldinit'.
		static CADMessageBase()
		{
			Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMessageBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr);
			CADMessageBase.NativeFieldInfoPtr__args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_args");
			CADMessageBase.NativeFieldInfoPtr__serializedArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_serializedArgs");
			CADMessageBase.NativeFieldInfoPtr__propertyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_propertyCount");
			CADMessageBase.NativeFieldInfoPtr__callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_callContext");
			CADMessageBase.NativeFieldInfoPtr_serializedMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "serializedMethod");
			CADMessageBase.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672769);
			CADMessageBase.NativeMethodInfoPtr_GetMethod_Internal_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672770);
			CADMessageBase.NativeMethodInfoPtr_GetSignature_Protected_Static_Il2CppReferenceArray_1_Type_MethodBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672771);
			CADMessageBase.NativeMethodInfoPtr_MarshalProperties_Internal_Static_Int32_IDictionary_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672772);
			CADMessageBase.NativeMethodInfoPtr_UnmarshalProperties_Internal_Static_Void_IDictionary_Int32_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672773);
			CADMessageBase.NativeMethodInfoPtr_IsPossibleToIgnoreMarshal_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672774);
			CADMessageBase.NativeMethodInfoPtr_MarshalArgument_Protected_Object_Object_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672775);
			CADMessageBase.NativeMethodInfoPtr_UnmarshalArgument_Protected_Object_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672776);
			CADMessageBase.NativeMethodInfoPtr_MarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672777);
			CADMessageBase.NativeMethodInfoPtr_UnmarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672778);
			CADMessageBase.NativeMethodInfoPtr_SaveLogicalCallContext_Protected_Void_IMethodMessage_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672779);
			CADMessageBase.NativeMethodInfoPtr_GetLogicalCallContext_Internal_LogicalCallContext_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672780);
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x0012D86C File Offset: 0x0012BA6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224053, RefRangeEnd = 224055, XrefRangeStart = 224048, XrefRangeEnd = 224053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADMessageBase(IMethodMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x0012D8B8 File Offset: 0x0012BAB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224061, RefRangeEnd = 224063, XrefRangeStart = 224055, XrefRangeEnd = 224061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodBase GetMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_GetMethod_Internal_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06004078 RID: 16504 RVA: 0x0012D8F8 File Offset: 0x0012BAF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224078, RefRangeEnd = 224079, XrefRangeStart = 224063, XrefRangeEnd = 224078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Type> GetSignature(MethodBase methodBase, bool load)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref load;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_GetSignature_Protected_Static_Il2CppReferenceArray_1_Type_MethodBase_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x0012D94C File Offset: 0x0012BB4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224128, RefRangeEnd = 224130, XrefRangeStart = 224079, XrefRangeEnd = 224128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MarshalProperties(IDictionary dict, ref ArrayList args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_MarshalProperties_Internal_Static_Int32_IDictionary_byref_ArrayList_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new ArrayList(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x0012D9B8 File Offset: 0x0012BBB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224135, RefRangeEnd = 224137, XrefRangeStart = 224130, XrefRangeEnd = 224135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnmarshalProperties(IDictionary dict, int count, ArrayList args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_UnmarshalProperties_Internal_Static_Void_IDictionary_Int32_ArrayList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x0012DA10 File Offset: 0x0012BC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224149, RefRangeEnd = 224150, XrefRangeStart = 224137, XrefRangeEnd = 224149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPossibleToIgnoreMarshal(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_IsPossibleToIgnoreMarshal_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x0012DA54 File Offset: 0x0012BC54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224163, RefRangeEnd = 224165, XrefRangeStart = 224150, XrefRangeEnd = 224163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object MarshalArgument(Object arg, ref ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_MarshalArgument_Protected_Object_Object_byref_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new ArrayList(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x0012DAD0 File Offset: 0x0012BCD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224272, RefRangeEnd = 224275, XrefRangeStart = 224165, XrefRangeEnd = 224272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object UnmarshalArgument(Object arg, ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_UnmarshalArgument_Protected_Object_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x0012DB34 File Offset: 0x0012BD34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224282, RefRangeEnd = 224284, XrefRangeStart = 224275, XrefRangeEnd = 224282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> MarshalArguments(Il2CppReferenceArray<Object> arguments, ref ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_MarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_byref_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new ArrayList(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr5) : null;
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x0012DBB0 File Offset: 0x0012BDB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 224291, RefRangeEnd = 224295, XrefRangeStart = 224284, XrefRangeEnd = 224291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> UnmarshalArguments(Il2CppReferenceArray<Object> arguments, ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_UnmarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x0012DC14 File Offset: 0x0012BE14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224307, RefRangeEnd = 224309, XrefRangeStart = 224295, XrefRangeEnd = 224307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(serializeList);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_SaveLogicalCallContext_Protected_Void_IMethodMessage_byref_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			serializeList = ((intPtr4 == 0) ? null : new ArrayList(intPtr4));
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x0012DC80 File Offset: 0x0012BE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224309, XrefRangeEnd = 224312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogicalCallContext GetLogicalCallContext(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_GetLogicalCallContext_Internal_LogicalCallContext_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x000183DC File Offset: 0x000165DC
		public CADMessageBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06004083 RID: 16515 RVA: 0x0012DCD0 File Offset: 0x0012BED0
		// (set) Token: 0x06004084 RID: 16516 RVA: 0x000183E5 File Offset: 0x000165E5
		public unsafe Il2CppReferenceArray<Object> _args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06004085 RID: 16517 RVA: 0x0012DD00 File Offset: 0x0012BF00
		// (set) Token: 0x06004086 RID: 16518 RVA: 0x00018404 File Offset: 0x00016604
		public unsafe Il2CppStructArray<byte> _serializedArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__serializedArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__serializedArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06004087 RID: 16519 RVA: 0x0012DD30 File Offset: 0x0012BF30
		// (set) Token: 0x06004088 RID: 16520 RVA: 0x00018423 File Offset: 0x00016623
		public unsafe int _propertyCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__propertyCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__propertyCount)) = value;
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06004089 RID: 16521 RVA: 0x0012DD58 File Offset: 0x0012BF58
		// (set) Token: 0x0600408A RID: 16522 RVA: 0x0001843E File Offset: 0x0001663E
		public unsafe CADArgHolder _callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CADArgHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x0600408B RID: 16523 RVA: 0x0012DD88 File Offset: 0x0012BF88
		// (set) Token: 0x0600408C RID: 16524 RVA: 0x0001845D File Offset: 0x0001665D
		public unsafe Il2CppStructArray<byte> serializedMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr_serializedMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr_serializedMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034DA RID: 13530
		private static readonly IntPtr NativeFieldInfoPtr__args;

		// Token: 0x040034DB RID: 13531
		private static readonly IntPtr NativeFieldInfoPtr__serializedArgs;

		// Token: 0x040034DC RID: 13532
		private static readonly IntPtr NativeFieldInfoPtr__propertyCount;

		// Token: 0x040034DD RID: 13533
		private static readonly IntPtr NativeFieldInfoPtr__callContext;

		// Token: 0x040034DE RID: 13534
		private static readonly IntPtr NativeFieldInfoPtr_serializedMethod;

		// Token: 0x040034DF RID: 13535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;

		// Token: 0x040034E0 RID: 13536
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Internal_MethodBase_0;

		// Token: 0x040034E1 RID: 13537
		private static readonly IntPtr NativeMethodInfoPtr_GetSignature_Protected_Static_Il2CppReferenceArray_1_Type_MethodBase_Boolean_0;

		// Token: 0x040034E2 RID: 13538
		private static readonly IntPtr NativeMethodInfoPtr_MarshalProperties_Internal_Static_Int32_IDictionary_byref_ArrayList_0;

		// Token: 0x040034E3 RID: 13539
		private static readonly IntPtr NativeMethodInfoPtr_UnmarshalProperties_Internal_Static_Void_IDictionary_Int32_ArrayList_0;

		// Token: 0x040034E4 RID: 13540
		private static readonly IntPtr NativeMethodInfoPtr_IsPossibleToIgnoreMarshal_Private_Static_Boolean_Object_0;

		// Token: 0x040034E5 RID: 13541
		private static readonly IntPtr NativeMethodInfoPtr_MarshalArgument_Protected_Object_Object_byref_ArrayList_0;

		// Token: 0x040034E6 RID: 13542
		private static readonly IntPtr NativeMethodInfoPtr_UnmarshalArgument_Protected_Object_Object_ArrayList_0;

		// Token: 0x040034E7 RID: 13543
		private static readonly IntPtr NativeMethodInfoPtr_MarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_byref_ArrayList_0;

		// Token: 0x040034E8 RID: 13544
		private static readonly IntPtr NativeMethodInfoPtr_UnmarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_ArrayList_0;

		// Token: 0x040034E9 RID: 13545
		private static readonly IntPtr NativeMethodInfoPtr_SaveLogicalCallContext_Protected_Void_IMethodMessage_byref_ArrayList_0;

		// Token: 0x040034EA RID: 13546
		private static readonly IntPtr NativeMethodInfoPtr_GetLogicalCallContext_Internal_LogicalCallContext_ArrayList_0;
	}
}
