using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200027A RID: 634
	public class SynchronizationContext : Object
	{
		// Token: 0x06002BC8 RID: 11208 RVA: 0x000E3330 File Offset: 0x000E1530
		// Note: this type is marked as 'beforefieldinit'.
		static SynchronizationContext()
		{
			Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SynchronizationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr);
			SynchronizationContext.NativeFieldInfoPtr__props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, "_props");
			SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, "s_cachedPreparedType1");
			SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, "s_cachedPreparedType2");
			SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, "s_cachedPreparedType3");
			SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, "s_cachedPreparedType4");
			SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, "s_cachedPreparedType5");
			SynchronizationContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670326);
			SynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670327);
			SynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_New_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670328);
			SynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670329);
			SynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670330);
			SynchronizationContext.NativeMethodInfoPtr_SetSynchronizationContext_Public_Static_Void_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670331);
			SynchronizationContext.NativeMethodInfoPtr_get_Current_Public_Static_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670332);
			SynchronizationContext.NativeMethodInfoPtr_get_CurrentNoFlow_Internal_Static_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670333);
			SynchronizationContext.NativeMethodInfoPtr_GetThreadLocalContext_Private_Static_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670334);
			SynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_New_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670335);
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000E34A0 File Offset: 0x000E16A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SynchronizationContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x000E34DC File Offset: 0x000E16DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201478, XrefRangeEnd = 201480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x000E353C File Offset: 0x000E173C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201480, XrefRangeEnd = 201488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Post(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_New_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x000E359C File Offset: 0x000E179C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OperationStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x000E35D8 File Offset: 0x000E17D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OperationCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x000E3614 File Offset: 0x000E1814
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 201490, RefRangeEnd = 201495, XrefRangeStart = 201488, XrefRangeEnd = 201490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSynchronizationContext(SynchronizationContext syncContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syncContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_SetSynchronizationContext_Public_Static_Void_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06002BCF RID: 11215 RVA: 0x000E364C File Offset: 0x000E184C
		public unsafe static SynchronizationContext Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 201500, RefRangeEnd = 201515, XrefRangeStart = 201495, XrefRangeEnd = 201500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_get_Current_Public_Static_get_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x000E3680 File Offset: 0x000E1880
		public unsafe static SynchronizationContext CurrentNoFlow
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 201520, RefRangeEnd = 201531, XrefRangeStart = 201515, XrefRangeEnd = 201520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_get_CurrentNoFlow_Internal_Static_get_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x000E36B4 File Offset: 0x000E18B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201531, XrefRangeEnd = 201535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SynchronizationContext GetThreadLocalContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_GetThreadLocalContext_Private_Static_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x000E36E8 File Offset: 0x000E18E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201535, XrefRangeEnd = 201538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SynchronizationContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_New_SynchronizationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x0000F1A6 File Offset: 0x0000D3A6
		public SynchronizationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x000E3734 File Offset: 0x000E1934
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x0000F1AF File Offset: 0x0000D3AF
		public unsafe SynchronizationContextProperties _props
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SynchronizationContext.NativeFieldInfoPtr__props);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SynchronizationContext.NativeFieldInfoPtr__props)) = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x000E375C File Offset: 0x000E195C
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x0000F1CA File Offset: 0x0000D3CA
		public unsafe static Type s_cachedPreparedType1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000E3784 File Offset: 0x000E1984
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x0000F1DC File Offset: 0x0000D3DC
		public unsafe static Type s_cachedPreparedType2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x000E37AC File Offset: 0x000E19AC
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x0000F1EE File Offset: 0x0000D3EE
		public unsafe static Type s_cachedPreparedType3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002BDC RID: 11228 RVA: 0x000E37D4 File Offset: 0x000E19D4
		// (set) Token: 0x06002BDD RID: 11229 RVA: 0x0000F200 File Offset: 0x0000D400
		public unsafe static Type s_cachedPreparedType4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x000E37FC File Offset: 0x000E19FC
		// (set) Token: 0x06002BDF RID: 11231 RVA: 0x0000F212 File Offset: 0x0000D412
		public unsafe static Type s_cachedPreparedType5
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType5, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SynchronizationContext.NativeFieldInfoPtr_s_cachedPreparedType5, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002643 RID: 9795
		private static readonly IntPtr NativeFieldInfoPtr__props;

		// Token: 0x04002644 RID: 9796
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedPreparedType1;

		// Token: 0x04002645 RID: 9797
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedPreparedType2;

		// Token: 0x04002646 RID: 9798
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedPreparedType3;

		// Token: 0x04002647 RID: 9799
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedPreparedType4;

		// Token: 0x04002648 RID: 9800
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedPreparedType5;

		// Token: 0x04002649 RID: 9801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400264A RID: 9802
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SendOrPostCallback_Object_0;

		// Token: 0x0400264B RID: 9803
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_New_Void_SendOrPostCallback_Object_0;

		// Token: 0x0400264C RID: 9804
		private static readonly IntPtr NativeMethodInfoPtr_OperationStarted_Public_Virtual_New_Void_0;

		// Token: 0x0400264D RID: 9805
		private static readonly IntPtr NativeMethodInfoPtr_OperationCompleted_Public_Virtual_New_Void_0;

		// Token: 0x0400264E RID: 9806
		private static readonly IntPtr NativeMethodInfoPtr_SetSynchronizationContext_Public_Static_Void_SynchronizationContext_0;

		// Token: 0x0400264F RID: 9807
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Static_get_SynchronizationContext_0;

		// Token: 0x04002650 RID: 9808
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentNoFlow_Internal_Static_get_SynchronizationContext_0;

		// Token: 0x04002651 RID: 9809
		private static readonly IntPtr NativeMethodInfoPtr_GetThreadLocalContext_Private_Static_SynchronizationContext_0;

		// Token: 0x04002652 RID: 9810
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_Virtual_New_SynchronizationContext_0;
	}
}
