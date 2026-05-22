using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000159 RID: 345
	public static class SocketTaskExtensions : Object
	{
		// Token: 0x06001644 RID: 5700 RVA: 0x0000B194 File Offset: 0x00009394
		// Note: this type is marked as 'beforefieldinit'.
		static SocketTaskExtensions()
		{
			Il2CppClassPointerStore<SocketTaskExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SocketTaskExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketTaskExtensions>.NativeClassPtr);
			SocketTaskExtensions.NativeMethodInfoPtr_ConnectAsync_Public_Static_Task_Socket_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketTaskExtensions>.NativeClassPtr, 100666455);
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x000646C0 File Offset: 0x000628C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 388367, RefRangeEnd = 388368, XrefRangeStart = 388336, XrefRangeEnd = 388367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task ConnectAsync(this Socket socket, EndPoint remoteEP)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketTaskExtensions.NativeMethodInfoPtr_ConnectAsync_Public_Static_Task_Socket_EndPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0000B1CD File Offset: 0x000093CD
		public SocketTaskExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_ConnectAsync_Public_Static_Task_Socket_EndPoint_0;

		// Token: 0x02000214 RID: 532
		[ObfuscatedName("System.Net.Sockets.SocketTaskExtensions+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D82 RID: 7554 RVA: 0x00077EA4 File Offset: 0x000760A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocketTaskExtensions>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr);
				SocketTaskExtensions.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr, "<>9");
				SocketTaskExtensions.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr, "<>9__2_0");
				SocketTaskExtensions.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr, "<>9__2_1");
				SocketTaskExtensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr, 100666457);
				SocketTaskExtensions.__c.NativeMethodInfoPtr__ConnectAsync_b__2_0_Internal_IAsyncResult_EndPoint_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr, 100666458);
				SocketTaskExtensions.__c.NativeMethodInfoPtr__ConnectAsync_b__2_1_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr, 100666459);
			}

			// Token: 0x06001D83 RID: 7555 RVA: 0x00077F48 File Offset: 0x00076148
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketTaskExtensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D84 RID: 7556 RVA: 0x00077F84 File Offset: 0x00076184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388323, XrefRangeEnd = 388328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult _ConnectAsync_b__2_0(EndPoint targetEndPoint, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetEndPoint);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketTaskExtensions.__c.NativeMethodInfoPtr__ConnectAsync_b__2_0_Internal_IAsyncResult_EndPoint_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001D85 RID: 7557 RVA: 0x00077FF8 File Offset: 0x000761F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388328, XrefRangeEnd = 388336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ConnectAsync_b__2_1(IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketTaskExtensions.__c.NativeMethodInfoPtr__ConnectAsync_b__2_1_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D86 RID: 7558 RVA: 0x0001025E File Offset: 0x0000E45E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000980 RID: 2432
			// (get) Token: 0x06001D87 RID: 7559 RVA: 0x0007803C File Offset: 0x0007623C
			// (set) Token: 0x06001D88 RID: 7560 RVA: 0x00010267 File Offset: 0x0000E467
			public unsafe static SocketTaskExtensions.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SocketTaskExtensions.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketTaskExtensions.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SocketTaskExtensions.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000981 RID: 2433
			// (get) Token: 0x06001D89 RID: 7561 RVA: 0x00078064 File Offset: 0x00076264
			// (set) Token: 0x06001D8A RID: 7562 RVA: 0x00010279 File Offset: 0x0000E479
			public unsafe static Func<EndPoint, AsyncCallback, Object, IAsyncResult> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SocketTaskExtensions.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EndPoint, AsyncCallback, Object, IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SocketTaskExtensions.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000982 RID: 2434
			// (get) Token: 0x06001D8B RID: 7563 RVA: 0x0007808C File Offset: 0x0007628C
			// (set) Token: 0x06001D8C RID: 7564 RVA: 0x0001028B File Offset: 0x0000E48B
			public unsafe static Action<IAsyncResult> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SocketTaskExtensions.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SocketTaskExtensions.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001660 RID: 5728
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001661 RID: 5729
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001662 RID: 5730
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04001663 RID: 5731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001664 RID: 5732
			private static readonly IntPtr NativeMethodInfoPtr__ConnectAsync_b__2_0_Internal_IAsyncResult_EndPoint_AsyncCallback_Object_0;

			// Token: 0x04001665 RID: 5733
			private static readonly IntPtr NativeMethodInfoPtr__ConnectAsync_b__2_1_Internal_Void_IAsyncResult_0;
		}
	}
}
