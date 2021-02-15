using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace College_Management_System.My
{
	// Token: 0x0200000A RID: 10
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00004860 File Offset: 0x00002A60
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void mljburxqcseitx(object e, EventArgs f)
		{
			bool saveMySettingsOnExit = yupufqwjlhlkfh.whvgmsxtmdbkxv.SaveMySettingsOnExit;
			if (saveMySettingsOnExit)
			{
				for (;;)
				{
					IL_111:
					int num = Form12.wsyoqrrjsoniul(49);
					int num2 = 10;
					for (;;)
					{
						num2 ^= 51;
						for (;;)
						{
							IL_5C:
							int num3 = 5;
							int num4 = 9;
							for (;;)
							{
								switch (num4 ^ 60)
								{
								case 50:
									goto IL_5C;
								case 51:
									switch (num3)
									{
									case 62:
										switch (num2)
										{
										case 54:
											goto IL_C7;
										case 55:
											switch (num + 49)
											{
											case 0:
												num = Form12.wsyoqrrjsoniul(56);
												goto IL_2A;
											case 1:
											{
												RuntimeMethodHandle runtimeMethodHandle = methodof(MySettings..cctor()).MethodHandle;
												num = -25;
												goto IL_2A;
											}
											case 2:
												yupufqwjlhlkfi.dgwiygpxcnrnjo.Save();
												num = -8;
												goto IL_2A;
											case 3:
												goto IL_171;
											}
											goto Block_4;
										case 56:
											goto IL_111;
										case 57:
											break;
										default:
											num3 = 4;
											goto IL_3B;
										}
										IL_2A:
										num ^= 55;
										break;
									case 63:
										break;
									case 64:
									{
										RuntimeMethodHandle runtimeMethodHandle2 = methodof(MySettings..ctor()).MethodHandle;
										num3 = 123;
										goto IL_3B;
									}
									case 65:
										goto IL_C2;
									default:
										num4 = 14;
										continue;
									}
									num2 = 4;
									num3 = 122;
									goto IL_3B;
								case 52:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(MySettings..ctor()).MethodHandle;
									num4 = 8;
									continue;
								}
								case 53:
									goto IL_3B;
								}
								IL_56:
								num4 = 15;
								continue;
								IL_3B:
								num3 ^= 59;
								goto IL_56;
							}
						}
						IL_C2:
						continue;
						IL_C7:
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(MySettings..ctor()).MethodHandle;
						num2 = 5;
						continue;
						Block_4:
						num2 = 11;
					}
				}
				IL_171:;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000049E0 File Offset: 0x00002BE0
		public static MySettings nyrllmycaxdxum
		{
			get
			{
				bool flag = !MySettings.addedHandler;
				if (flag)
				{
					object obj;
					for (;;)
					{
						IL_7E:
						int num = Form2.uwpnsrqhswlmjh(44);
						int num2 = Form7.mqgfoefwabbyeu(29);
						for (;;)
						{
							num2 ^= 60;
							switch (num2 + 57)
							{
							case 0:
								switch (num + 55)
								{
								case 0:
									ObjectFlowControl.CheckForSyncLockOnValueType(obj);
									num = -4;
									goto IL_26;
								case 1:
									num = -5;
									goto IL_26;
								case 2:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(MySettings..cctor()).MethodHandle;
									num = -3;
									goto IL_26;
								}
								case 3:
									obj = MySettings.addedHandlerLockObject;
									num = -1;
									goto IL_26;
								case 4:
									goto IL_E3;
								default:
									num2 = -11;
									continue;
								}
								break;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle2 = methodof(MySettings..cctor()).MethodHandle;
								num2 = -12;
								continue;
							}
							case 2:
								goto IL_7E;
							case 3:
								goto IL_26;
							}
							IL_43:
							num2 = Form2.uwpnsrqhswlmjh(34);
							continue;
							IL_26:
							num ^= 54;
							goto IL_43;
						}
					}
					IL_E3:
					lock (obj)
					{
						for (;;)
						{
							int num3 = Form2.uwpnsrqhswlmjh(44);
							for (;;)
							{
								num3 ^= 55;
								switch (num3 + 52)
								{
								case 0:
								{
									bool flag3 = !MySettings.addedHandler;
									num3 = Form12.wsyoqrrjsoniul(51);
									continue;
								}
								case 1:
									num3 = -5;
									continue;
								case 2:
								{
									bool flag3;
									if (flag3)
									{
										num3 = -25;
										continue;
									}
									goto IL_15D;
								}
								case 3:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(MySettings.mljburxqcseitx(object, EventArgs)).MethodHandle;
									num3 = -8;
									continue;
								}
								case 4:
									goto IL_15A;
								}
								break;
							}
						}
						IL_15A:
						bool flag4 = false;
						goto IL_160;
						IL_15D:
						flag4 = true;
						IL_160:
						if (!flag4)
						{
							yupufqwjlhlkfh.whvgmsxtmdbkxv.Shutdown += MySettings.mljburxqcseitx;
							for (;;)
							{
								int num4 = 4;
								for (;;)
								{
									switch (num4 ^ 49)
									{
									case 53:
										num4 = 7;
										continue;
									case 54:
										MySettings.addedHandler = true;
										num4 = 9;
										continue;
									case 55:
									{
										RuntimeMethodHandle runtimeMethodHandle4 = methodof(MySettings.get_nyrllmycaxdxum()).MethodHandle;
										num4 = 6;
										continue;
									}
									case 56:
										goto IL_1BD;
									}
									break;
								}
							}
							IL_1BD:;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x04000018 RID: 24
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000019 RID: 25
		private static bool addedHandler;

		// Token: 0x0400001A RID: 26
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
